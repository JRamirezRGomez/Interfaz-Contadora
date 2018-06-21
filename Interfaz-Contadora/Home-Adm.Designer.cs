namespace Interfaz_Contadora
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Home = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnNuevoTransporte = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.PanelSlide = new System.Windows.Forms.Panel();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.PanelHome = new System.Windows.Forms.Panel();
            this.BtnSlide = new System.Windows.Forms.Button();
            this.BtnMinimizar = new System.Windows.Forms.Button();
            this.PanelBarra = new System.Windows.Forms.Panel();
            this.BtnMaximizar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Slider = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Home)).BeginInit();
            this.PanelSlide.SuspendLayout();
            this.PanelHome.SuspendLayout();
            this.PanelBarra.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Home
            // 
            this.Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Home.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Home.Image = ((System.Drawing.Image)(resources.GetObject("Home.Image")));
            this.Home.Location = new System.Drawing.Point(149, 40);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(260, 150);
            this.Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Home.TabIndex = 0;
            this.Home.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.Location = new System.Drawing.Point(225, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "¡Bienvenido!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.Location = new System.Drawing.Point(205, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Daniel Alonso Soto";
            // 
            // BtnSalir
            // 
            this.BtnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(104)))), ((int)(((byte)(60)))));
            this.BtnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(104)))), ((int)(((byte)(60)))));
            this.BtnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.BtnSalir.ForeColor = System.Drawing.Color.Transparent;
            this.BtnSalir.Location = new System.Drawing.Point(833, 0);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnSalir.Size = new System.Drawing.Size(45, 38);
            this.BtnSalir.TabIndex = 3;
            this.BtnSalir.Text = "X";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnNuevoTransporte
            // 
            this.BtnNuevoTransporte.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnNuevoTransporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(104)))), ((int)(((byte)(60)))));
            this.BtnNuevoTransporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNuevoTransporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevoTransporte.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.BtnNuevoTransporte.ForeColor = System.Drawing.Color.White;
            this.BtnNuevoTransporte.Location = new System.Drawing.Point(149, 268);
            this.BtnNuevoTransporte.Name = "BtnNuevoTransporte";
            this.BtnNuevoTransporte.Size = new System.Drawing.Size(260, 30);
            this.BtnNuevoTransporte.TabIndex = 4;
            this.BtnNuevoTransporte.Text = "Nuevo Transporte";
            this.BtnNuevoTransporte.UseVisualStyleBackColor = false;
            this.BtnNuevoTransporte.Click += new System.EventHandler(this.BtnNuevoTransporte_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(377, 34);
            this.label3.TabIndex = 5;
            this.label3.Text = "Capture un nuevo transporte o haga click en la parte superior \r\nizquierda para ve" +
    "r los transportes capturados";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PanelSlide
            // 
            this.PanelSlide.Controls.Add(this.TxtBuscar);
            this.PanelSlide.Location = new System.Drawing.Point(45, 38);
            this.PanelSlide.Name = "PanelSlide";
            this.PanelSlide.Size = new System.Drawing.Size(256, 430);
            this.PanelSlide.TabIndex = 6;
            this.PanelSlide.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelSlide_Paint);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.BackColor = System.Drawing.Color.White;
            this.TxtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBuscar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic);
            this.TxtBuscar.Location = new System.Drawing.Point(3, 7);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(250, 21);
            this.TxtBuscar.TabIndex = 1;
            this.TxtBuscar.Text = "Buscador";
            // 
            // PanelHome
            // 
            this.PanelHome.Controls.Add(this.BtnSlide);
            this.PanelHome.Location = new System.Drawing.Point(0, 38);
            this.PanelHome.Name = "PanelHome";
            this.PanelHome.Size = new System.Drawing.Size(45, 430);
            this.PanelHome.TabIndex = 0;
            // 
            // BtnSlide
            // 
            this.BtnSlide.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnSlide.AutoSize = true;
            this.BtnSlide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSlide.BackgroundImage")));
            this.BtnSlide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSlide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSlide.ForeColor = System.Drawing.Color.White;
            this.BtnSlide.Location = new System.Drawing.Point(-1, 0);
            this.BtnSlide.Name = "BtnSlide";
            this.BtnSlide.Size = new System.Drawing.Size(46, 26);
            this.BtnSlide.TabIndex = 1;
            this.BtnSlide.UseVisualStyleBackColor = true;
            this.BtnSlide.Click += new System.EventHandler(this.BtnSlide_Click);
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(104)))), ((int)(((byte)(60)))));
            this.BtnMinimizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(104)))), ((int)(((byte)(60)))));
            this.BtnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.BtnMinimizar.ForeColor = System.Drawing.Color.Transparent;
            this.BtnMinimizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnMinimizar.Location = new System.Drawing.Point(735, 0);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnMinimizar.Size = new System.Drawing.Size(47, 38);
            this.BtnMinimizar.TabIndex = 7;
            this.BtnMinimizar.Text = "___";
            this.BtnMinimizar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnMinimizar.UseVisualStyleBackColor = false;
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // PanelBarra
            // 
            this.PanelBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(104)))), ((int)(((byte)(60)))));
            this.PanelBarra.Controls.Add(this.BtnMaximizar);
            this.PanelBarra.Controls.Add(this.label4);
            this.PanelBarra.Controls.Add(this.BtnMinimizar);
            this.PanelBarra.Controls.Add(this.BtnSalir);
            this.PanelBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBarra.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.PanelBarra.Location = new System.Drawing.Point(0, 0);
            this.PanelBarra.Name = "PanelBarra";
            this.PanelBarra.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PanelBarra.Size = new System.Drawing.Size(878, 38);
            this.PanelBarra.TabIndex = 8;
            this.PanelBarra.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelBarra_Paint);
            // 
            // BtnMaximizar
            // 
            this.BtnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMaximizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(104)))), ((int)(((byte)(60)))));
            this.BtnMaximizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(104)))), ((int)(((byte)(60)))));
            this.BtnMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMaximizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.BtnMaximizar.ForeColor = System.Drawing.Color.Transparent;
            this.BtnMaximizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnMaximizar.Location = new System.Drawing.Point(788, 0);
            this.BtnMaximizar.Name = "BtnMaximizar";
            this.BtnMaximizar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnMaximizar.Size = new System.Drawing.Size(50, 38);
            this.BtnMaximizar.TabIndex = 8;
            this.BtnMaximizar.Text = "[    ]";
            this.BtnMaximizar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnMaximizar.UseVisualStyleBackColor = false;
            this.BtnMaximizar.Click += new System.EventHandler(this.BtnMaximizar_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(-2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(380, 38);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contadora de Varillas";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Slider
            // 
            this.Slider.Tick += new System.EventHandler(this.Slider_Tick);
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.Home);
            this.panel1.Controls.Add(this.BtnNuevoTransporte);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(302, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 427);
            this.panel1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(878, 467);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelBarra);
            this.Controls.Add(this.PanelHome);
            this.Controls.Add(this.PanelSlide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Home)).EndInit();
            this.PanelSlide.ResumeLayout(false);
            this.PanelSlide.PerformLayout();
            this.PanelHome.ResumeLayout(false);
            this.PanelHome.PerformLayout();
            this.PanelBarra.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Home;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnNuevoTransporte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel PanelSlide;
        private System.Windows.Forms.Button BtnMinimizar;
        private System.Windows.Forms.Panel PanelHome;
        private System.Windows.Forms.Button BtnSlide;
        private System.Windows.Forms.Panel PanelBarra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnMaximizar;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Timer Slider;
        private System.Windows.Forms.Panel panel1;
    }
}

