namespace ToodeDB
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
            this.Toode = new System.Windows.Forms.TextBox();
            this.Kogus = new System.Windows.Forms.TextBox();
            this.Hinne = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.LisaPilt = new System.Windows.Forms.DataGridView();
            this.toodetableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toodedDataSet = new ToodeDB.ToodedDataSet();
            this.toodetableTableAdapter = new ToodeDB.ToodedDataSetTableAdapters.ToodetableTableAdapter();
            this.btnPilt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.LisaPilt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toodetableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toodedDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Toode
            // 
            this.Toode.Location = new System.Drawing.Point(144, 51);
            this.Toode.Name = "Toode";
            this.Toode.Size = new System.Drawing.Size(100, 20);
            this.Toode.TabIndex = 0;
            // 
            // Kogus
            // 
            this.Kogus.Location = new System.Drawing.Point(144, 78);
            this.Kogus.Name = "Kogus";
            this.Kogus.Size = new System.Drawing.Size(100, 20);
            this.Kogus.TabIndex = 1;
            // 
            // Hinne
            // 
            this.Hinne.Location = new System.Drawing.Point(144, 105);
            this.Hinne.Name = "Hinne";
            this.Hinne.Size = new System.Drawing.Size(100, 20);
            this.Hinne.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Toode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kogus";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hind";
            // 
            // btn_new
            // 
            this.btn_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btn_new.Location = new System.Drawing.Point(34, 164);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(75, 23);
            this.btn_new.TabIndex = 6;
            this.btn_new.Text = "Lisa uus";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btn_update.Location = new System.Drawing.Point(36, 193);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 7;
            this.btn_update.Text = "Uuenda";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btn_Delete.Location = new System.Drawing.Point(36, 222);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 8;
            this.btn_Delete.Text = "Kustuta";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // LisaPilt
            // 
            this.LisaPilt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LisaPilt.Location = new System.Drawing.Point(321, 54);
            this.LisaPilt.Name = "LisaPilt";
            this.LisaPilt.Size = new System.Drawing.Size(441, 150);
            this.LisaPilt.TabIndex = 9;
            this.LisaPilt.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // toodetableBindingSource
            // 
            this.toodetableBindingSource.DataMember = "Toodetable";
            this.toodetableBindingSource.DataSource = this.toodedDataSet;
            // 
            // toodedDataSet
            // 
            this.toodedDataSet.DataSetName = "ToodedDataSet";
            this.toodedDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toodetableTableAdapter
            // 
            this.toodetableTableAdapter.ClearBeforeFill = true;
            // 
            // btnPilt
            // 
            this.btnPilt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnPilt.Location = new System.Drawing.Point(36, 252);
            this.btnPilt.Name = "btnPilt";
            this.btnPilt.Size = new System.Drawing.Size(75, 23);
            this.btnPilt.TabIndex = 10;
            this.btnPilt.Text = "Lisa pilt";
            this.btnPilt.UseVisualStyleBackColor = true;
            this.btnPilt.Click += new System.EventHandler(this.btnPilt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(321, 222);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(441, 216);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(144, 131);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(119, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPilt);
            this.Controls.Add(this.LisaPilt);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Hinne);
            this.Controls.Add(this.Kogus);
            this.Controls.Add(this.Toode);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.LisaPilt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toodetableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toodedDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Toode;
        private System.Windows.Forms.TextBox Kogus;
        private System.Windows.Forms.TextBox Hinne;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.DataGridView LisaPilt;
        private ToodedDataSet toodedDataSet;
        private System.Windows.Forms.BindingSource toodetableBindingSource;
        private ToodedDataSetTableAdapters.ToodetableTableAdapter toodetableTableAdapter;
        private System.Windows.Forms.Button btnPilt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

