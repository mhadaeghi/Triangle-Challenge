namespace TriangleChallenge
{
    partial class findingTriangleType
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
            this.fSideLbl = new System.Windows.Forms.Label();
            this.sSideLbl = new System.Windows.Forms.Label();
            this.tSideLbl = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.submitBtn = new System.Windows.Forms.Button();
            this.resultTitleLbl = new System.Windows.Forms.Label();
            this.fSideInp = new System.Windows.Forms.TextBox();
            this.sSideInp = new System.Windows.Forms.TextBox();
            this.tSideInp = new System.Windows.Forms.TextBox();
            this.toolTipError = new System.Windows.Forms.ToolTip(this.components);
            this.firsTtlLbl = new System.Windows.Forms.Label();
            this.resultTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // fSideLbl
            // 
            this.fSideLbl.AutoSize = true;
            this.fSideLbl.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fSideLbl.Location = new System.Drawing.Point(46, 96);
            this.fSideLbl.Name = "fSideLbl";
            this.fSideLbl.Size = new System.Drawing.Size(141, 22);
            this.fSideLbl.TabIndex = 0;
            this.fSideLbl.Text = "First Side lenght";
            // 
            // sSideLbl
            // 
            this.sSideLbl.AutoSize = true;
            this.sSideLbl.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sSideLbl.Location = new System.Drawing.Point(251, 96);
            this.sSideLbl.Name = "sSideLbl";
            this.sSideLbl.Size = new System.Drawing.Size(162, 22);
            this.sSideLbl.TabIndex = 1;
            this.sSideLbl.Text = "Second Side Lenght";
            // 
            // tSideLbl
            // 
            this.tSideLbl.AutoSize = true;
            this.tSideLbl.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSideLbl.Location = new System.Drawing.Point(456, 96);
            this.tSideLbl.Name = "tSideLbl";
            this.tSideLbl.Size = new System.Drawing.Size(150, 22);
            this.tSideLbl.TabIndex = 2;
            this.tSideLbl.Text = "Third Side Lenght";
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(219, 198);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 30);
            this.clearBtn.TabIndex = 9;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.Location = new System.Drawing.Point(359, 198);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 30);
            this.submitBtn.TabIndex = 10;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // resultTitleLbl
            // 
            this.resultTitleLbl.AutoSize = true;
            this.resultTitleLbl.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultTitleLbl.Location = new System.Drawing.Point(298, 275);
            this.resultTitleLbl.Name = "resultTitleLbl";
            this.resultTitleLbl.Size = new System.Drawing.Size(66, 22);
            this.resultTitleLbl.TabIndex = 11;
            this.resultTitleLbl.Text = "Result:";
            // 
            // fSideInp
            // 
            this.fSideInp.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fSideInp.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.fSideInp.Location = new System.Drawing.Point(68, 131);
            this.fSideInp.Name = "fSideInp";
            this.fSideInp.Size = new System.Drawing.Size(100, 29);
            this.fSideInp.TabIndex = 13;
            this.fSideInp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fSideInp.Validating += new System.ComponentModel.CancelEventHandler(this.fSideInp_Validating);
            // 
            // sSideInp
            // 
            this.sSideInp.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sSideInp.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.sSideInp.Location = new System.Drawing.Point(280, 131);
            this.sSideInp.Name = "sSideInp";
            this.sSideInp.Size = new System.Drawing.Size(100, 29);
            this.sSideInp.TabIndex = 14;
            this.sSideInp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sSideInp.Validating += new System.ComponentModel.CancelEventHandler(this.sSideInp_Validating);
            // 
            // tSideInp
            // 
            this.tSideInp.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSideInp.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tSideInp.Location = new System.Drawing.Point(480, 131);
            this.tSideInp.Name = "tSideInp";
            this.tSideInp.Size = new System.Drawing.Size(100, 29);
            this.tSideInp.TabIndex = 15;
            this.tSideInp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tSideInp.Validating += new System.ComponentModel.CancelEventHandler(this.tSideInp_Validating);
            // 
            // toolTipError
            // 
            this.toolTipError.AutomaticDelay = 0;
            // 
            // firsTtlLbl
            // 
            this.firsTtlLbl.AutoSize = true;
            this.firsTtlLbl.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firsTtlLbl.Location = new System.Drawing.Point(12, 43);
            this.firsTtlLbl.Name = "firsTtlLbl";
            this.firsTtlLbl.Size = new System.Drawing.Size(163, 22);
            this.firsTtlLbl.TabIndex = 16;
            this.firsTtlLbl.Text = "Insert The Lenghts:";
            // 
            // resultTxtBox
            // 
            this.resultTxtBox.BackColor = System.Drawing.SystemColors.Menu;
            this.resultTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultTxtBox.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultTxtBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.resultTxtBox.Location = new System.Drawing.Point(150, 306);
            this.resultTxtBox.Name = "resultTxtBox";
            this.resultTxtBox.Size = new System.Drawing.Size(358, 22);
            this.resultTxtBox.TabIndex = 17;
            this.resultTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // findingTriangleType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 481);
            this.Controls.Add(this.resultTxtBox);
            this.Controls.Add(this.firsTtlLbl);
            this.Controls.Add(this.tSideInp);
            this.Controls.Add(this.sSideInp);
            this.Controls.Add(this.fSideInp);
            this.Controls.Add(this.resultTitleLbl);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.tSideLbl);
            this.Controls.Add(this.sSideLbl);
            this.Controls.Add(this.fSideLbl);
            this.Name = "findingTriangleType";
            this.Text = "Finding Triangle Type";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fSideLbl;
        private System.Windows.Forms.Label sSideLbl;
        private System.Windows.Forms.Label tSideLbl;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label resultTitleLbl;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label firsTtlLbl;
        private System.Windows.Forms.TextBox sSideInp;
        private System.Windows.Forms.TextBox tSideInp;
        private System.Windows.Forms.TextBox fSideInp;
        private System.Windows.Forms.ToolTip toolTipError;
        private System.Windows.Forms.TextBox resultTxtBox;
    }
}

