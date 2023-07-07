namespace Imagens
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pbImage = new PictureBox();
            btnOpen = new Button();
            lblImagePath = new Label();
            btnSave = new Button();
            pbLoad = new PictureBox();
            btnCarregar = new Button();
            dgvAnimals = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            image = new DataGridViewImageColumn();
            name = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLoad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).BeginInit();
            SuspendLayout();
            // 
            // pbImage
            // 
            pbImage.BackColor = SystemColors.Control;
            pbImage.Location = new Point(33, 29);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(234, 212);
            pbImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbImage.TabIndex = 0;
            pbImage.TabStop = false;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(33, 261);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(75, 23);
            btnOpen.TabIndex = 1;
            btnOpen.Text = "Abrir";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // lblImagePath
            // 
            lblImagePath.AutoSize = true;
            lblImagePath.Location = new Point(33, 395);
            lblImagePath.Name = "lblImagePath";
            lblImagePath.Size = new Size(16, 15);
            lblImagePath.TabIndex = 2;
            lblImagePath.Text = "...";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(143, 261);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 3;
            btnSave.Text = "Salvar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // pbLoad
            // 
            pbLoad.BackColor = SystemColors.Control;
            pbLoad.Location = new Point(309, 29);
            pbLoad.Name = "pbLoad";
            pbLoad.Size = new Size(235, 212);
            pbLoad.SizeMode = PictureBoxSizeMode.Zoom;
            pbLoad.TabIndex = 4;
            pbLoad.TabStop = false;
            // 
            // btnCarregar
            // 
            btnCarregar.Location = new Point(389, 261);
            btnCarregar.Name = "btnCarregar";
            btnCarregar.Size = new Size(75, 23);
            btnCarregar.TabIndex = 5;
            btnCarregar.Text = "Carregar";
            btnCarregar.UseVisualStyleBackColor = true;
            btnCarregar.Click += btnCarregar_Click;
            // 
            // dgvAnimals
            // 
            dgvAnimals.AllowUserToAddRows = false;
            dgvAnimals.AllowUserToDeleteRows = false;
            dgvAnimals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAnimals.Columns.AddRange(new DataGridViewColumn[] { Id, image, name });
            dgvAnimals.Location = new Point(591, 29);
            dgvAnimals.Name = "dgvAnimals";
            dgvAnimals.ReadOnly = true;
            dgvAnimals.RowTemplate.Height = 25;
            dgvAnimals.Size = new Size(324, 217);
            dgvAnimals.TabIndex = 6;
            // 
            // Id
            // 
            Id.DataPropertyName = "id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // image
            // 
            image.DataPropertyName = "imageBmp";
            image.HeaderText = "Imagem";
            image.ImageLayout = DataGridViewImageCellLayout.Zoom;
            image.Name = "image";
            image.ReadOnly = true;
            // 
            // name
            // 
            name.DataPropertyName = "name";
            name.HeaderText = "Nome";
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 450);
            Controls.Add(dgvAnimals);
            Controls.Add(btnCarregar);
            Controls.Add(pbLoad);
            Controls.Add(btnSave);
            Controls.Add(lblImagePath);
            Controls.Add(btnOpen);
            Controls.Add(pbImage);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLoad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbImage;
        private Button btnOpen;
        private Label lblImagePath;
        private Button btnSave;
        private PictureBox pbLoad;
        private Button btnCarregar;
        private DataGridView dgvAnimals;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewImageColumn image;
        private DataGridViewTextBoxColumn name;
    }
}