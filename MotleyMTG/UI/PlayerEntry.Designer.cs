namespace MotleyMTG.UI
{
    partial class PlayerEntry
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdSeat = new System.Windows.Forms.Button();
            this.dgPlayers = new System.Windows.Forms.DataGridView();
            this.Players = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdSeat
            // 
            this.cmdSeat.Location = new System.Drawing.Point(428, 231);
            this.cmdSeat.Name = "cmdSeat";
            this.cmdSeat.Size = new System.Drawing.Size(129, 39);
            this.cmdSeat.TabIndex = 0;
            this.cmdSeat.Text = "Seat Players";
            this.cmdSeat.UseVisualStyleBackColor = true;
            this.cmdSeat.Click += new System.EventHandler(this.cmdSeat_Click);
            // 
            // dgPlayers
            // 
            this.dgPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPlayers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Players});
            this.dgPlayers.Location = new System.Drawing.Point(4, 4);
            this.dgPlayers.Name = "dgPlayers";
            this.dgPlayers.RowTemplate.Height = 28;
            this.dgPlayers.Size = new System.Drawing.Size(409, 266);
            this.dgPlayers.TabIndex = 1;
            // 
            // Players
            // 
            this.Players.HeaderText = "Players";
            this.Players.Name = "Players";
            // 
            // PlayerEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgPlayers);
            this.Controls.Add(this.cmdSeat);
            this.Name = "PlayerEntry";
            this.Size = new System.Drawing.Size(576, 287);
            ((System.ComponentModel.ISupportInitialize)(this.dgPlayers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdSeat;
        private System.Windows.Forms.DataGridView dgPlayers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Players;
    }
}
