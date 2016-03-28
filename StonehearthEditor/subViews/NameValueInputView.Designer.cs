namespace StonehearthEditor.subViews
{
   partial class NameValueInputView
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
         this.nameLabel = new System.Windows.Forms.Label();
         this.inputTextBox = new System.Windows.Forms.TextBox();
         this.SuspendLayout();
         // 
         // nameLabel
         // 
         this.nameLabel.AutoSize = true;
         this.nameLabel.Location = new System.Drawing.Point(3, 3);
         this.nameLabel.Name = "nameLabel";
         this.nameLabel.Size = new System.Drawing.Size(33, 13);
         this.nameLabel.TabIndex = 0;
         this.nameLabel.Text = "name";
         // 
         // inputTextBox
         // 
         this.inputTextBox.Location = new System.Drawing.Point(42, 0);
         this.inputTextBox.Name = "inputTextBox";
         this.inputTextBox.Size = new System.Drawing.Size(119, 20);
         this.inputTextBox.TabIndex = 1;
         // 
         // NameValueInputView
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.inputTextBox);
         this.Controls.Add(this.nameLabel);
         this.Name = "NameValueInputView";
         this.Size = new System.Drawing.Size(165, 22);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label nameLabel;
      private System.Windows.Forms.TextBox inputTextBox;
   }
}
