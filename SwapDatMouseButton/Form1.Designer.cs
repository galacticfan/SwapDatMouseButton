namespace SwapDatMouseButton
{
    partial class MainForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.startUpCreate = new System.Windows.Forms.Button();
            this.startUpDelete = new System.Windows.Forms.Button();
            this.swapMouseBtn = new System.Windows.Forms.Button();
            this.msgLog = new System.Windows.Forms.TextBox();
            this.msgLogLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.swapMouseBtn);
            this.splitContainer1.Panel1.Controls.Add(this.startUpDelete);
            this.splitContainer1.Panel1.Controls.Add(this.startUpCreate);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer1.Panel2.Controls.Add(this.msgLogLabel);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.msgLog);
            this.splitContainer1.Size = new System.Drawing.Size(284, 161);
            this.splitContainer1.SplitterDistance = 107;
            this.splitContainer1.TabIndex = 0;
            // 
            // startUpCreate
            // 
            this.startUpCreate.Location = new System.Drawing.Point(12, 69);
            this.startUpCreate.Name = "startUpCreate";
            this.startUpCreate.Size = new System.Drawing.Size(80, 37);
            this.startUpCreate.TabIndex = 0;
            this.startUpCreate.Text = "Create Startup File";
            this.startUpCreate.UseVisualStyleBackColor = true;
            // 
            // startUpDelete
            // 
            this.startUpDelete.Location = new System.Drawing.Point(12, 112);
            this.startUpDelete.Name = "startUpDelete";
            this.startUpDelete.Size = new System.Drawing.Size(80, 37);
            this.startUpDelete.TabIndex = 1;
            this.startUpDelete.Text = "Delete Startup File";
            this.startUpDelete.UseVisualStyleBackColor = true;
            // 
            // swapMouseBtn
            // 
            this.swapMouseBtn.Location = new System.Drawing.Point(12, 12);
            this.swapMouseBtn.Name = "swapMouseBtn";
            this.swapMouseBtn.Size = new System.Drawing.Size(80, 37);
            this.swapMouseBtn.TabIndex = 2;
            this.swapMouseBtn.Text = "Swap Mouse Buttons";
            this.swapMouseBtn.UseVisualStyleBackColor = true;
            // 
            // msgLog
            // 
            this.msgLog.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.msgLog.Location = new System.Drawing.Point(13, 69);
            this.msgLog.Multiline = true;
            this.msgLog.Name = "msgLog";
            this.msgLog.ReadOnly = true;
            this.msgLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.msgLog.Size = new System.Drawing.Size(148, 80);
            this.msgLog.TabIndex = 0;
            // 
            // msgLogLabel
            // 
            this.msgLogLabel.AutoSize = true;
            this.msgLogLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgLogLabel.Location = new System.Drawing.Point(10, 53);
            this.msgLogLabel.Name = "msgLogLabel";
            this.msgLogLabel.Size = new System.Drawing.Size(74, 13);
            this.msgLogLabel.TabIndex = 1;
            this.msgLogLabel.Text = "Message Log:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 52);
            this.label1.TabIndex = 2;
            this.label1.Text = "If you want to temporarily swap \r\nthe mouse buttons, press the\r\n\"Swap Mouse Butto" +
    "ns\" button.\r\n\r\n";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "Swap Dat\' Mouse Button";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button startUpCreate;
        private System.Windows.Forms.Button startUpDelete;
        private System.Windows.Forms.Button swapMouseBtn;
        private System.Windows.Forms.TextBox msgLog;
        private System.Windows.Forms.Label msgLogLabel;
        private System.Windows.Forms.Label label1;
    }
}

