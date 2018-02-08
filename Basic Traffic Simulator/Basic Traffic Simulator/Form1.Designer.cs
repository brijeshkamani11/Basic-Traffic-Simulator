namespace Basic_Traffic_Simulator
{
    partial class main
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
            this.redlight = new System.Windows.Forms.PictureBox();
            this.yellowlight = new System.Windows.Forms.PictureBox();
            this.greenlight = new System.Windows.Forms.PictureBox();
            this.Holder = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_remTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.redlight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowlight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenlight)).BeginInit();
            this.Holder.SuspendLayout();
            this.SuspendLayout();
            // 
            // redlight
            // 
            this.redlight.Location = new System.Drawing.Point(13, 21);
            this.redlight.Name = "redlight";
            this.redlight.Size = new System.Drawing.Size(100, 84);
            this.redlight.TabIndex = 0;
            this.redlight.TabStop = false;
            // 
            // yellowlight
            // 
            this.yellowlight.Location = new System.Drawing.Point(13, 123);
            this.yellowlight.Name = "yellowlight";
            this.yellowlight.Size = new System.Drawing.Size(100, 84);
            this.yellowlight.TabIndex = 1;
            this.yellowlight.TabStop = false;
            // 
            // greenlight
            // 
            this.greenlight.Location = new System.Drawing.Point(13, 228);
            this.greenlight.Name = "greenlight";
            this.greenlight.Size = new System.Drawing.Size(100, 84);
            this.greenlight.TabIndex = 2;
            this.greenlight.TabStop = false;
            // 
            // Holder
            // 
            this.Holder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Holder.Controls.Add(this.redlight);
            this.Holder.Controls.Add(this.greenlight);
            this.Holder.Controls.Add(this.yellowlight);
            this.Holder.Location = new System.Drawing.Point(184, 109);
            this.Holder.Name = "Holder";
            this.Holder.Size = new System.Drawing.Size(128, 334);
            this.Holder.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Remaining Time :";
            // 
            // lbl_remTime
            // 
            this.lbl_remTime.AutoSize = true;
            this.lbl_remTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_remTime.Location = new System.Drawing.Point(294, 59);
            this.lbl_remTime.Name = "lbl_remTime";
            this.lbl_remTime.Size = new System.Drawing.Size(0, 29);
            this.lbl_remTime.TabIndex = 5;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 526);
            this.Controls.Add(this.lbl_remTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Holder);
            this.Name = "main";
            this.Text = "Traffic Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.redlight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowlight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenlight)).EndInit();
            this.Holder.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox redlight;
        private System.Windows.Forms.PictureBox yellowlight;
        private System.Windows.Forms.PictureBox greenlight;
        private System.Windows.Forms.Panel Holder;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_remTime;
    }
}

