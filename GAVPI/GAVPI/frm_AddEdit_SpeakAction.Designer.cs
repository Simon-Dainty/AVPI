﻿namespace GAVPI
{
    partial class frm_AddEdit_SpeakAction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AddEdit_SpeakAction));
            this.chckMultiAdd = new System.Windows.Forms.CheckBox();
            this.txtTimesToAdd = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblSpeak = new System.Windows.Forms.Label();
            this.cbSpeechValue = new System.Windows.Forms.ComboBox();
            this.cbSpeechType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chckMultiAdd
            // 
            this.chckMultiAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chckMultiAdd.AutoSize = true;
            this.chckMultiAdd.Location = new System.Drawing.Point(12, 114);
            this.chckMultiAdd.Name = "chckMultiAdd";
            this.chckMultiAdd.Size = new System.Drawing.Size(115, 17);
            this.chckMultiAdd.TabIndex = 3;
            this.chckMultiAdd.Text = "Add Multiple Times";
            this.chckMultiAdd.UseVisualStyleBackColor = true;
            this.chckMultiAdd.CheckedChanged += new System.EventHandler(this.chckMultiAdd_CheckedChanged);
            // 
            // txtTimesToAdd
            // 
            this.txtTimesToAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTimesToAdd.Enabled = false;
            this.txtTimesToAdd.Location = new System.Drawing.Point(134, 112);
            this.txtTimesToAdd.Name = "txtTimesToAdd";
            this.txtTimesToAdd.Size = new System.Drawing.Size(72, 20);
            this.txtTimesToAdd.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(297, 112);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(216, 112);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblSpeak
            // 
            this.lblSpeak.AutoSize = true;
            this.lblSpeak.Location = new System.Drawing.Point(9, 28);
            this.lblSpeak.Name = "lblSpeak";
            this.lblSpeak.Size = new System.Drawing.Size(88, 13);
            this.lblSpeak.TabIndex = 16;
            this.lblSpeak.Text = "Speak Item Type";
            // 
            // cbSpeechValue
            // 
            this.cbSpeechValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSpeechValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpeechValue.FormattingEnabled = true;
            this.cbSpeechValue.Location = new System.Drawing.Point(103, 70);
            this.cbSpeechValue.Name = "cbSpeechValue";
            this.cbSpeechValue.Size = new System.Drawing.Size(277, 21);
            this.cbSpeechValue.TabIndex = 2;
            // 
            // cbSpeechType
            // 
            this.cbSpeechType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSpeechType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpeechType.FormattingEnabled = true;
            this.cbSpeechType.Location = new System.Drawing.Point(103, 25);
            this.cbSpeechType.Name = "cbSpeechType";
            this.cbSpeechType.Size = new System.Drawing.Size(277, 21);
            this.cbSpeechType.TabIndex = 1;
            this.cbSpeechType.SelectedIndexChanged += new System.EventHandler(this.cbSpeechType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Speak Item";
            // 
            // frm_AddEdit_SpeakAction
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(392, 147);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbSpeechType);
            this.Controls.Add(this.cbSpeechValue);
            this.Controls.Add(this.chckMultiAdd);
            this.Controls.Add(this.txtTimesToAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblSpeak);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(402, 177);
            this.Name = "frm_AddEdit_SpeakAction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Speak Action";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chckMultiAdd;
        private System.Windows.Forms.TextBox txtTimesToAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblSpeak;
        private System.Windows.Forms.ComboBox cbSpeechValue;
        private System.Windows.Forms.ComboBox cbSpeechType;
        private System.Windows.Forms.Label label2;
    }
}