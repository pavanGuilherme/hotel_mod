namespace Hotel_Mod
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_settings = new System.Windows.Forms.Button();
            this.btn_checkin = new System.Windows.Forms.Button();
            this.btn_fornecedor = new System.Windows.Forms.Button();
            this.btn_checkout = new System.Windows.Forms.Button();
            this.btn_cliente = new System.Windows.Forms.Button();
            this.btn_pais = new System.Windows.Forms.Button();
            this.btn_cidade = new System.Windows.Forms.Button();
            this.btn_estado = new System.Windows.Forms.Button();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_settings);
            this.panel1.Controls.Add(this.btn_checkin);
            this.panel1.Controls.Add(this.btn_fornecedor);
            this.panel1.Controls.Add(this.btn_checkout);
            this.panel1.Controls.Add(this.btn_cliente);
            this.panel1.Controls.Add(this.btn_pais);
            this.panel1.Controls.Add(this.btn_cidade);
            this.panel1.Controls.Add(this.btn_estado);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 795);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(138, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 15.70909F);
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "GpSystem";
            // 
            // btn_settings
            // 
            this.btn_settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_settings.FlatAppearance.BorderSize = 0;
            this.btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_settings.Font = new System.Drawing.Font("Segoe UI", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_settings.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_settings.Image = ((System.Drawing.Image)(resources.GetObject("btn_settings.Image")));
            this.btn_settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_settings.Location = new System.Drawing.Point(0, 620);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(220, 67);
            this.btn_settings.TabIndex = 8;
            this.btn_settings.Text = "   Settings";
            this.btn_settings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_settings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_settings.UseVisualStyleBackColor = false;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // btn_checkin
            // 
            this.btn_checkin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_checkin.FlatAppearance.BorderSize = 0;
            this.btn_checkin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_checkin.Font = new System.Drawing.Font("Segoe UI", 9.818182F);
            this.btn_checkin.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_checkin.Image = ((System.Drawing.Image)(resources.GetObject("btn_checkin.Image")));
            this.btn_checkin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_checkin.Location = new System.Drawing.Point(0, 95);
            this.btn_checkin.Name = "btn_checkin";
            this.btn_checkin.Size = new System.Drawing.Size(220, 67);
            this.btn_checkin.TabIndex = 1;
            this.btn_checkin.Text = "   Check-In";
            this.btn_checkin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_checkin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_checkin.UseVisualStyleBackColor = false;
            this.btn_checkin.Click += new System.EventHandler(this.btn_checkin_Click);
            // 
            // btn_fornecedor
            // 
            this.btn_fornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_fornecedor.FlatAppearance.BorderSize = 0;
            this.btn_fornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_fornecedor.Font = new System.Drawing.Font("Segoe UI", 9.818182F);
            this.btn_fornecedor.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_fornecedor.Image = ((System.Drawing.Image)(resources.GetObject("btn_fornecedor.Image")));
            this.btn_fornecedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_fornecedor.Location = new System.Drawing.Point(0, 545);
            this.btn_fornecedor.Name = "btn_fornecedor";
            this.btn_fornecedor.Size = new System.Drawing.Size(220, 67);
            this.btn_fornecedor.TabIndex = 7;
            this.btn_fornecedor.Text = "  Fornecedores";
            this.btn_fornecedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_fornecedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_fornecedor.UseVisualStyleBackColor = false;
            this.btn_fornecedor.Click += new System.EventHandler(this.btn_fornecedor_Click);
            // 
            // btn_checkout
            // 
            this.btn_checkout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_checkout.FlatAppearance.BorderSize = 0;
            this.btn_checkout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_checkout.Font = new System.Drawing.Font("Segoe UI", 9.818182F);
            this.btn_checkout.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_checkout.Image = ((System.Drawing.Image)(resources.GetObject("btn_checkout.Image")));
            this.btn_checkout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_checkout.Location = new System.Drawing.Point(0, 170);
            this.btn_checkout.Name = "btn_checkout";
            this.btn_checkout.Size = new System.Drawing.Size(220, 67);
            this.btn_checkout.TabIndex = 2;
            this.btn_checkout.Text = "   Check-Out";
            this.btn_checkout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_checkout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_checkout.UseVisualStyleBackColor = false;
            this.btn_checkout.Click += new System.EventHandler(this.btn_checkout_Click);
            // 
            // btn_cliente
            // 
            this.btn_cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_cliente.FlatAppearance.BorderSize = 0;
            this.btn_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cliente.Font = new System.Drawing.Font("Segoe UI", 9.818182F);
            this.btn_cliente.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_cliente.Image = ((System.Drawing.Image)(resources.GetObject("btn_cliente.Image")));
            this.btn_cliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cliente.Location = new System.Drawing.Point(0, 470);
            this.btn_cliente.Name = "btn_cliente";
            this.btn_cliente.Size = new System.Drawing.Size(220, 67);
            this.btn_cliente.TabIndex = 6;
            this.btn_cliente.Text = "Clientes";
            this.btn_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cliente.UseVisualStyleBackColor = false;
            this.btn_cliente.Click += new System.EventHandler(this.btn_cliente_Click);
            // 
            // btn_pais
            // 
            this.btn_pais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_pais.FlatAppearance.BorderSize = 0;
            this.btn_pais.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_pais.Font = new System.Drawing.Font("Segoe UI", 9.818182F);
            this.btn_pais.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_pais.Image = ((System.Drawing.Image)(resources.GetObject("btn_pais.Image")));
            this.btn_pais.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pais.Location = new System.Drawing.Point(0, 245);
            this.btn_pais.Name = "btn_pais";
            this.btn_pais.Size = new System.Drawing.Size(220, 67);
            this.btn_pais.TabIndex = 3;
            this.btn_pais.Text = "   País";
            this.btn_pais.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pais.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_pais.UseVisualStyleBackColor = false;
            this.btn_pais.Click += new System.EventHandler(this.btn_pais_Click);
            // 
            // btn_cidade
            // 
            this.btn_cidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_cidade.FlatAppearance.BorderSize = 0;
            this.btn_cidade.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cidade.Font = new System.Drawing.Font("Segoe UI", 9.818182F);
            this.btn_cidade.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_cidade.Image = ((System.Drawing.Image)(resources.GetObject("btn_cidade.Image")));
            this.btn_cidade.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cidade.Location = new System.Drawing.Point(0, 395);
            this.btn_cidade.Name = "btn_cidade";
            this.btn_cidade.Size = new System.Drawing.Size(220, 67);
            this.btn_cidade.TabIndex = 5;
            this.btn_cidade.Text = "  Cidade";
            this.btn_cidade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cidade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cidade.UseVisualStyleBackColor = false;
            this.btn_cidade.Click += new System.EventHandler(this.btn_cidade_Click);
            // 
            // btn_estado
            // 
            this.btn_estado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_estado.FlatAppearance.BorderSize = 0;
            this.btn_estado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_estado.Font = new System.Drawing.Font("Segoe UI", 9.818182F);
            this.btn_estado.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_estado.Image = ((System.Drawing.Image)(resources.GetObject("btn_estado.Image")));
            this.btn_estado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_estado.Location = new System.Drawing.Point(0, 320);
            this.btn_estado.Name = "btn_estado";
            this.btn_estado.Size = new System.Drawing.Size(220, 67);
            this.btn_estado.TabIndex = 4;
            this.btn_estado.Text = "  Estado";
            this.btn_estado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_estado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_estado.UseVisualStyleBackColor = false;
            this.btn_estado.Click += new System.EventHandler(this.btn_estado_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitleBar.Controls.Add(this.btn_close);
            this.panelTitleBar.Controls.Add(this.lbl_title);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1005, 98);
            this.panelTitleBar.TabIndex = 1;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(17, 33);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(31, 32);
            this.btn_close.TabIndex = 1;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Visible = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Nirmala UI", 15.70909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(466, 33);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(83, 32);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "HOME";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(220, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1005, 697);
            this.panel2.TabIndex = 2;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1225, 795);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panel1);
            this.Name = "Principal";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_checkin;
        private System.Windows.Forms.Button btn_checkout;
        private System.Windows.Forms.Button btn_pais;
        private System.Windows.Forms.Button btn_estado;
        private System.Windows.Forms.Button btn_cidade;
        private System.Windows.Forms.Button btn_cliente;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Button btn_fornecedor;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_close;
    }
}

