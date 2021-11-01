using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System.Drawing.Design;

namespace DemoCHDM.CustomCotrol
{
    [DefaultEvent("OnSelectedIndexChanged")]
    class ComboboxControl : UserControl
    {
        //Fields
        private Color backCorlor = Color.White;
        private Color iconColor = Color.Black;
        private Color listBackColor = Color.White;
        private Color listTextColor = Color.DimGray;
        private Color borderColor = Color.FromArgb(239, 75, 75);
        private int borderSize = 1;

        //Items
        private ComboBox cboList;
        private Label lbText;
        private Button btIcon;

        //Properties
        //Appearance
        [Category("ComboBox Appearance")]
        public new Color BackCorlor
        {
            get 
            { 
                return backCorlor; 
            }
            set
            {
                backCorlor = value;
                lbText.BackColor = backCorlor;
                btIcon.BackColor = backCorlor;
            }
        }

        [Category("ComboBox Appearance")]
        public Color IconColor
        {
            get 
            { 
                return iconColor; 
            }
            set
            {
                iconColor = value;
                btIcon.Invalidate(); //Redraw icon
            }
        }

        [Category("ComboBox Appearance")]
        public Color ListBackColor
        {
            get 
            { 
                return listBackColor; 
            }
            set
            {
                listBackColor = value;
                cboList.BackColor = listBackColor;
            }
        }

        [Category("ComboBox Appearance")]
        public Color ListTextColor
        {
            get
            { 
                return listTextColor; 
            }
            set
            {
                listTextColor = value;
                cboList.ForeColor = listTextColor;
            }
        }

        [Category("ComboBox Appearance")]
        public Color BorderColor { get
            {
                return borderColor;
            }
            set
            {
                borderColor = value;
                base.BackColor = borderColor; //Border Color
            } 
        }

        [Category("ComboBox Appearance")]
        public int BorderSize { get
            {
                return borderSize;
            }
            set
            {
                borderSize = value;
                this.Padding = new Padding(borderSize); //Border size
                AdjustComboBoxDimensions();
            } 
        }

        [Category("ComboBox Appearance")]
        public override Color ForeColor
        {
            get
            {
                return base.ForeColor;
            }

            set
            {
                base.ForeColor = value;
                lbText.ForeColor = value;
            }
        }

        [Category("ComboBox Appearance")]
        public override Font Font
        {
            get
            {
                return base.Font;
            }

            set
            {
                base.Font = value;
                lbText.Font = value;
                cboList.Font = value; //Optional
            }
        }

        [Category("ComboBox Appearance")]
        public string Texts
        {
            get
            {
                return lbText.Text;
            }
            set
            {
                lbText.Text = value;
            }
        }

        [Category("ComboBox Appearance")]
        public ComboBoxStyle DropDownStyle
        {
            get
            {
                return cboList.DropDownStyle;
            }
            set
            {
                if(cboList.DropDownStyle != ComboBoxStyle.Simple)
                    cboList.DropDownStyle = value;
            }
        }

        //Data
        [Category("ComboBox Code - Data")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [Localizable(true)]
        [MergableProperty(false)]

        public ComboBox.ObjectCollection Items 
        {
            get { return cboList.Items; }
        }

        [Category("ComboBox Code - Data")]
        [AttributeProvider(typeof(IListSource))]
        [DefaultValue(null)]
        [RefreshProperties(RefreshProperties.Repaint)]

        public object DataSource 
        {
            get { return cboList.DataSource; }
            set
            {
                cboList.DataSource = value;
            } 
        }

        [Category("ComboBox Code - Data")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Localizable(true)]

        public AutoCompleteStringCollection AutoCompleteCustomSource 
        {
            get { return cboList.AutoCompleteCustomSource; }
            set
            {
                cboList.AutoCompleteCustomSource = value;
            }
        }

        [Category("ComboBox Code - Data")]
        [Browsable(true)]
        [DefaultValue(AutoCompleteSource.None)]
        [EditorBrowsable(EditorBrowsableState.Always)]

        public AutoCompleteSource AutoCompleteSource 
        {
            get { return cboList.AutoCompleteSource; }
            set { cboList.AutoCompleteSource = value; }
        }

        [Category("ComboBox Code - Data")]
        [Browsable(true)]
        [DefaultValue(AutoCompleteMode.None)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteMode AutoCompleteMode 
        {
            get { return cboList.AutoCompleteMode; }
            set { cboList.AutoCompleteMode = value; }
        }

        [Category("ComboBox Code - Data")]
        [Bindable(true)]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
 
        public object SelectedItem 
        {
            get { return cboList.SelectedItem; }
            set { cboList.SelectedItem = value; }
        }
        
        [Category("ComboBox Code - Data")]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SelectedIndex 
        {
            get { return cboList.SelectedIndex; }
            set { cboList.SelectedIndex = value; }
        }

        //Events
        public event EventHandler OnSelectedIndexChanged; //default event

        //Constructor
        public ComboboxControl()
        {
            cboList = new ComboBox();
            lbText = new Label();
            btIcon = new Button();

            //Combobox: Drodown list
            cboList.BackColor = listBackColor;
            cboList.Font = new Font(this.Font.Name, 10F);
            cboList.ForeColor = listTextColor;
            cboList.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged); //Default event
            cboList.TextChanged += new EventHandler(ComboBox_TextChanged); //Refresh text

            //Button: Icon
            btIcon.Dock = DockStyle.Right;
            btIcon.FlatStyle = FlatStyle.Flat;
            btIcon.FlatAppearance.BorderSize = 0;
            btIcon.BackColor = backCorlor;
            btIcon.Size = new Size(30, 30);
            btIcon.Cursor = Cursors.Hand;
            btIcon.Click += new EventHandler(Icon_Click); //Open dropdown
            btIcon.Paint += new PaintEventHandler(Icon_Paint); //Draw icon

            //Label: Text
            lbText.Dock = DockStyle.Fill;
            lbText.AutoSize = false;
            lbText.BackColor = backCorlor;
            lbText.TextAlign = ContentAlignment.MiddleLeft;
            lbText.Padding = new Padding(8,0,0,0);
            lbText.Font = new Font(this.Font.Name, 10F);
            //Attach label events to user control event
            lbText.Click += new EventHandler(Surface_Click); //Select comboBox
            lbText.MouseEnter += new EventHandler(Surface_MouseEnter);
            lbText.MouseLeave += new EventHandler(Surface_MouseLeave);

            //User Control
            this.Controls.Add(lbText);//2
            this.Controls.Add(btIcon);//1
            this.Controls.Add(cboList);//0
            this.MinimumSize = new Size(200, 30);
            this.Size = new Size(200, 30);
            this.ForeColor = Color.DarkGray;
            this.Padding = new Padding(borderSize); //Border size
            base.BackColor = borderColor; //Border Color
            this.ResumeLayout();
            AdjustComboBoxDimensions();
        }

        private void AdjustComboBoxDimensions()
        {
            cboList.Width = lbText.Width;
            cboList.Location = new Point()
            {
                X = this.Width - this.Padding.Right - cboList.Width,
                Y = lbText.Bottom - cboList.Height
            };
        }

        //Event methods
        //Default event
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OnSelectedIndexChanged != null)
            {
                OnSelectedIndexChanged.Invoke(sender, e);
            }
            //Refrefresh text
            lbText.Text = cboList.Text;
        }

        //Draw icon
        private void Icon_Paint(object sender, PaintEventArgs e)
        {
            //Fields
            int iconWidht = 14;
            int iconHeight = 6;
            var rectIcon = new Rectangle((btIcon.Width - iconWidht) / 2, (btIcon.Height - iconHeight) / 2, iconWidht, iconHeight);
            Graphics graph = e.Graphics;
            //Draw arrow down icon
            using (GraphicsPath path = new GraphicsPath())
            using (Pen pen = new Pen(iconColor, 2))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                path.AddLine(rectIcon.X, rectIcon.Y, rectIcon.X + (iconWidht / 2), rectIcon.Bottom);
                path.AddLine(rectIcon.X + (iconWidht / 2), rectIcon.Bottom, rectIcon.Right, rectIcon.Y);
                graph.DrawPath(pen, path);
            }
        }
        //items actions
        private void Icon_Click(object sender, EventArgs e)
        {
            //Open dropdown list
            cboList.Select();
            cboList.DroppedDown = true;
        }

        private void Surface_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
            //Select comboBox
            cboList.Select();
            if (cboList.DropDownStyle == ComboBoxStyle.DropDownList)
                cboList.DroppedDown = true; //Open dropdown list
        }
        
        private void ComboBox_TextChanged(object sender, EventArgs e)
        {
            //Refrefresh text
            lbText.Text = cboList.Text;
        }

        //Attach label events to user control event
        private void Surface_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void Surface_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        //////////
        //Overridden methods
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            AdjustComboBoxDimensions();
        }
    }
}
