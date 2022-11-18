using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using WallE.Errors;
using System.Threading.Tasks;
using System.Windows.Forms;
using WallE.Tools;
using WallE.Rout;

namespace WallE_Visual.WorldViewer
{
    public partial class ViewProcForm : Form
    {
        #region Fields
        private IProgrammable wallE;
        private int countRepetitions;
        private bool CreateNew;
        #endregion

        #region Constructors
        public ViewProcForm( )
        {
            InitializeComponent( );

            HideTrackBar( );

            this.btnAdd.Enabled = false;
            
            this.lblRutName.Text = string.Empty;
        }
        public ViewProcForm(IProgrammable wObjects) : this( )
        {
            this.wallE = wObjects;
            if ( wallE.ListRout.Count != 0 )
                this.btnDelete.Enabled = true;
            else
                this.btnDelete.Enabled = false;
            RefreshCombo( );
        }
        #endregion

        #region Events
        private void btnLoad_Click(object sender,EventArgs e)
        {
            LoadRut( );
        }
        private void btnNew_Click(object sender,EventArgs e)
        {
            NewRut( );
        }
        private void btnDelete_Click(object sender,EventArgs e)
        {
            DeleteRut( );
        }
        private void cboxList_SelectedIndexChanged(object sender,EventArgs e)
        {
            if ( !CreateNew )
                ShowSelectedProc( );
        }
        private void btnAdd_Click(object sender,EventArgs e)
        {
            AddRut( );
        }
        private void btnSave_Click(object sender,EventArgs e)
        {
            SaveRut( );
        }
        private void tbarZoom_Scroll(object sender,EventArgs e)
        {
            Zoom_Scroll( );
        }
        private void Helpbtn_Click(object sender,EventArgs e)
        {
            new HelpViewProc( ).ShowDialog( );
        }

        private void startDebug_Click(object sender, EventArgs e)
        {
            RefreshCombo();
            this.Close();
        }
        #endregion

        #region Methods
        private void SaveRut( )
        {
            if ( this.rutView.Routine == null )
            {
                string message = "Нет выбранной процедуры для экспорта.";

                message += this.cboxList.Items.Count == 0 ? "Нет созданных определений" : "\nВыберите один из списка подпрограмм, а затем экспортируйте его.";
                MessageBox.Show(message,"Нет определений",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                if ( this.folderBrowser.ShowDialog( ) == DialogResult.OK )
                {
                    string path = this.folderBrowser.SelectedPath;
                    try { ControllerRoutine.SaveRoutine(this.rutView.Routine,path); }
                    catch(Exception e )
                    {
                        MessageBox.Show(e.Message,"Несуществующие инструкции.",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        return;
                    }
                }
            }
        }
        private void AddRut( )
        {
            if ( !Proc.ValidateRut(rutView.Routine) )
            {
                Error error = new Error("Определения: \"" + rutView.Routine.Name + "\" не имеет  {start}, поэтому процедуру нельзя добавить.");
                MessageBox.Show(error.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            foreach ( var item in wallE.ListRout)
            {
                if ( item.Name == rutView.Routine.Name )
                    rutView.Routine.Name += " " + ++countRepetitions;
            }
            this.wallE.ListRout.AddRoutine(this.rutView.Routine);
            btnDelete.Enabled = true;
            btnAdd.Enabled = false;
            CreateNew = false;
            this.lblRutName.Text = this.rutView.Routine.Name;
            RefreshCombo( );
        }
        private void DeleteRut( )
        {
            string rutToDeleteByName = (string) this.cboxList.SelectedItem;

            foreach ( var ruts in wallE.ListRout)
                if ( ruts.Name == rutToDeleteByName )
                {
                    wallE.ListRout.RemoveRoutineAt(ruts.Index);
                    break;
                }

            RefreshCombo( );

            this.rutView = new RutViews( );
            this.pnlRutineView.Controls.Clear( );
            this.rutView.Parent = this.pnlRutineView;
            this.rutView.Refresh( );
            this.pnlRutineView.Refresh( );

            if ( this.cboxList.Items.Count == 0 )
            {
                this.btnDelete.Enabled = false;
                this.btnAdd.Enabled = false;
                HideTrackBar( );
                this.lblRutName.Text = string.Empty;
                return;
            }
            ShowSelectedProc( );
        }
        private bool IsNumber(string word)
        {
            for ( int i = 0; i < word.Length; i++ )
                if ( !Char.IsLetter(word[i]) )
                    return true;
            return false;
        }
        private void LoadRut( )
        {
            if ( this.ofileLoadRut.ShowDialog( ) == DialogResult.OK )
            {
                foreach ( var file in this.ofileLoadRut.FileNames )
                {
                    Proc rut = null;
                    bool loadOk = false;
                    try
                    {
                        var tempRut = ControllerRoutine.LoadRoutine(file,out loadOk);
                        if ( loadOk )
                            rut = tempRut;
                    }
                    catch ( Exception e )
                    {
                        MessageBox.Show(e.Message + "\nНельзя загрузить процедуру.","Ошибка импорта.",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        return;
                    }

                    bool exist = false;
                    foreach ( var item in wallE.ListRout)
                        if ( item.Equals(rut) )
                        {
                            exist = true;
                            break;
                        }
                    if ( !exist )
                        wallE.ListRout.AddRoutine(rut);
                }
            }
            this.btnDelete.Enabled = true;
            RefreshCombo( );
        }
        private void RefreshCombo( )
        {
            this.cboxList.Items.Clear( );

            var list = wallE.ListRout.Select(new Func<Proc,object>(c =>
          {
              if ( c.Name == null || c.Name == string.Empty )
                  return c.Index;
              return c.Name;
          })).ToList( );

            if ( list != null )
            {
                this.cboxList.Items.AddRange(list.ToArray( ));

                if ( list.Count != 0 )
                    this.cboxList.SelectedItem = list.ToArray( )[0];
            }
        }
        private void NewRut( )
        {
            AddProcForm add = new AddProcForm( );

            if ( add.ShowDialog( ) == DialogResult.OK )
            {
                this.pnlRutineView.Controls.Clear( );

                CreateNew = true;
                this.rutView = new RutViews( );
                this.rutView.SetRut(add.Row,add.Column);
                this.rutView.Routine.Name = add.Name;

                this.rutView.Parent = this.pnlRutineView;
                this.rutView.Refresh( );

                this.pnlRutineView.Refresh( );
                this.btnAdd.Enabled = true;
                this.lblZoom.Visible = true;
                this.lblMin.Visible = true;
                this.lblMax.Visible = true;
                this.tbarZoom.Visible = true;
                RefreshCombo( );
                this.rutView.Refresh( );
                ViewTrackBar( );
                this.lblRutName.Text = rutView.Routine.Name;
            }
        }
        private void ShowSelectedProc( )
        {
            Proc selectedRut = wallE.ListRout.Where(c => ( c.Name == (string) this.cboxList.SelectedItem )).Take(1).ToArray( )[0];

            this.rutView.SetRut(selectedRut);
            this.pnlRutineView.Controls.Clear( );
            this.rutView.Parent = this.pnlRutineView;
            this.rutView.Refresh( );
            this.pnlRutineView.Refresh( );

            this.lblRutName.Text = rutView.Routine.Name;

            ViewTrackBar( );
        }
        private void ViewTrackBar( )
        {
            this.lblZoom.Visible = true;
            this.lblMin.Visible = true;
            this.lblMax.Visible = true;
            this.tbarZoom.Visible = true;
        }
        private void HideTrackBar( )
        {
            this.tbarZoom.Visible = false;
            this.lblZoom.Visible = false;
            this.lblMax.Visible = false;
            this.lblMin.Visible = false;
        }
        private void Zoom_Scroll( )
        {
            this.rutView.ModifySize(this.tbarZoom.Value,this.tbarZoom.Maximum);
        }

        #endregion

        
    }
}
