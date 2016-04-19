namespace AsyncAwaitTestWinForm
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
            this.buttonTask = new System.Windows.Forms.Button();
            this.buttonAwait = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBoxMain = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonDeadlock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonTask
            // 
            this.buttonTask.Location = new System.Drawing.Point(13, 13);
            this.buttonTask.Name = "buttonTask";
            this.buttonTask.Size = new System.Drawing.Size(159, 36);
            this.buttonTask.TabIndex = 0;
            this.buttonTask.Text = "Fetch Data (with Task)";
            this.buttonTask.UseVisualStyleBackColor = true;
            this.buttonTask.Click += new System.EventHandler(this.buttonTask_Click);
            // 
            // buttonAwait
            // 
            this.buttonAwait.Location = new System.Drawing.Point(12, 55);
            this.buttonAwait.Name = "buttonAwait";
            this.buttonAwait.Size = new System.Drawing.Size(159, 36);
            this.buttonAwait.TabIndex = 1;
            this.buttonAwait.Text = "Fetch Data (with await)";
            this.buttonAwait.UseVisualStyleBackColor = true;
            this.buttonAwait.Click += new System.EventHandler(this.buttonAwait_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(12, 197);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(159, 36);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.Text = "Clear Data";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textBoxMain
            // 
            this.textBoxMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMain.Location = new System.Drawing.Point(179, 13);
            this.textBoxMain.Multiline = true;
            this.textBoxMain.Name = "textBoxMain";
            this.textBoxMain.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMain.Size = new System.Drawing.Size(368, 220);
            this.textBoxMain.TabIndex = 3;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Enabled = false;
            this.buttonCancel.Location = new System.Drawing.Point(12, 155);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(159, 36);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel request";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonDeadlock
            // 
            this.buttonDeadlock.Location = new System.Drawing.Point(12, 97);
            this.buttonDeadlock.Name = "buttonDeadlock";
            this.buttonDeadlock.Size = new System.Drawing.Size(159, 36);
            this.buttonDeadlock.TabIndex = 5;
            this.buttonDeadlock.Text = "Deadlock";
            this.buttonDeadlock.UseVisualStyleBackColor = true;
            this.buttonDeadlock.Click += new System.EventHandler(this.buttonDeadlock_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 245);
            this.Controls.Add(this.buttonDeadlock);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxMain);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonAwait);
            this.Controls.Add(this.buttonTask);
            this.MinimumSize = new System.Drawing.Size(520, 284);
            this.Name = "MainForm";
            this.Text = "Async/Await test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTask;
        private System.Windows.Forms.Button buttonAwait;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBoxMain;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonDeadlock;
    }
}

