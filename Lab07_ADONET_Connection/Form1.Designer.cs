namespace Lab07_ADONET_Connection
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
            components = new System.ComponentModel.Container();
            btnKiemTra = new System.Windows.Forms.Button();
            SuspendLayout();

            // btnKiemTra
            btnKiemTra.Location = new System.Drawing.Point(350, 200);
            btnKiemTra.Name = "btnKiemTra";
            btnKiemTra.Size = new System.Drawing.Size(100, 40);
            btnKiemTra.TabIndex = 0;
            btnKiemTra.Text = "Kiểm Tra Kết Nối";
            btnKiemTra.UseVisualStyleBackColor = true;
            btnKiemTra.Click += new System.EventHandler(btnKiemTra_Click);

            // Form1
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnKiemTra);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnKiemTra;
    }
}
