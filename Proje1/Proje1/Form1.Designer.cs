namespace Proje1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnaddcar = new System.Windows.Forms.Button();
            this.btnsort = new System.Windows.Forms.Button();
            this.txtatc = new System.Windows.Forms.TextBox();
            this.btnatc = new System.Windows.Forms.Button();
            this.rtxtcircular = new System.Windows.Forms.RichTextBox();
            this.rtxtpriority = new System.Windows.Forms.RichTextBox();
            this.rtxtfd = new System.Windows.Forms.RichTextBox();
            this.btnfind = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightCyan;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(29, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Circular Queue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.IndianRed;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(243, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Priority Queue";
            // 
            // btnaddcar
            // 
            this.btnaddcar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnaddcar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnaddcar.Location = new System.Drawing.Point(44, 43);
            this.btnaddcar.Name = "btnaddcar";
            this.btnaddcar.Size = new System.Drawing.Size(100, 27);
            this.btnaddcar.TabIndex = 4;
            this.btnaddcar.Text = "Add Car";
            this.btnaddcar.UseVisualStyleBackColor = false;
            this.btnaddcar.Click += new System.EventHandler(this.btnaddcar_Click);
            // 
            // btnsort
            // 
            this.btnsort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsort.Location = new System.Drawing.Point(248, 43);
            this.btnsort.Name = "btnsort";
            this.btnsort.Size = new System.Drawing.Size(101, 27);
            this.btnsort.TabIndex = 5;
            this.btnsort.Text = "Sort";
            this.btnsort.UseVisualStyleBackColor = true;
            this.btnsort.Click += new System.EventHandler(this.btnsort_Click);
            // 
            // txtatc
            // 
            this.txtatc.Location = new System.Drawing.Point(207, 298);
            this.txtatc.Name = "txtatc";
            this.txtatc.Size = new System.Drawing.Size(64, 20);
            this.txtatc.TabIndex = 8;
            // 
            // btnatc
            // 
            this.btnatc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnatc.Location = new System.Drawing.Point(73, 293);
            this.btnatc.Name = "btnatc";
            this.btnatc.Size = new System.Drawing.Size(128, 28);
            this.btnatc.TabIndex = 10;
            this.btnatc.Text = "Average Time:";
            this.btnatc.UseVisualStyleBackColor = true;
            this.btnatc.Click += new System.EventHandler(this.btnatc_Click);
            // 
            // rtxtcircular
            // 
            this.rtxtcircular.Location = new System.Drawing.Point(12, 72);
            this.rtxtcircular.Name = "rtxtcircular";
            this.rtxtcircular.Size = new System.Drawing.Size(177, 207);
            this.rtxtcircular.TabIndex = 18;
            this.rtxtcircular.Text = "";
            // 
            // rtxtpriority
            // 
            this.rtxtpriority.Location = new System.Drawing.Point(221, 72);
            this.rtxtpriority.Name = "rtxtpriority";
            this.rtxtpriority.Size = new System.Drawing.Size(177, 207);
            this.rtxtpriority.TabIndex = 19;
            this.rtxtpriority.Text = "";
            // 
            // rtxtfd
            // 
            this.rtxtfd.Location = new System.Drawing.Point(422, 72);
            this.rtxtfd.Name = "rtxtfd";
            this.rtxtfd.Size = new System.Drawing.Size(177, 207);
            this.rtxtfd.TabIndex = 21;
            this.rtxtfd.Text = "";
            // 
            // btnfind
            // 
            this.btnfind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnfind.Location = new System.Drawing.Point(457, 43);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(97, 27);
            this.btnfind.TabIndex = 23;
            this.btnfind.Text = "Find differences";
            this.btnfind.UseVisualStyleBackColor = true;
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(625, 333);
            this.Controls.Add(this.btnfind);
            this.Controls.Add(this.rtxtfd);
            this.Controls.Add(this.rtxtpriority);
            this.Controls.Add(this.rtxtcircular);
            this.Controls.Add(this.btnatc);
            this.Controls.Add(this.txtatc);
            this.Controls.Add(this.btnsort);
            this.Controls.Add(this.btnaddcar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnaddcar;
        private System.Windows.Forms.Button btnsort;
        private System.Windows.Forms.TextBox txtatc;
        private System.Windows.Forms.Button btnatc;
        private System.Windows.Forms.RichTextBox rtxtcircular;
        private System.Windows.Forms.RichTextBox rtxtpriority;
        private System.Windows.Forms.RichTextBox rtxtfd;
        private System.Windows.Forms.Button btnfind;
    }
}

