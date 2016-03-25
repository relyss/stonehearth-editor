namespace StonehearthEditor.subViews
{
   partial class vec2InputView
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
         this.xLabel = new System.Windows.Forms.Label();
         this.yLabel = new System.Windows.Forms.Label();
         this.xTextBox = new System.Windows.Forms.TextBox();
         this.yTextBox = new System.Windows.Forms.TextBox();
         this.SuspendLayout();
         // 
         // xLabel
         // 
         this.xLabel.AutoSize = true;
         this.xLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.xLabel.Location = new System.Drawing.Point(23, 0);
         this.xLabel.Name = "xLabel";
         this.xLabel.Size = new System.Drawing.Size(27, 20);
         this.xLabel.TabIndex = 0;
         this.xLabel.Text = "x :";
         // 
         // yLabel
         // 
         this.yLabel.AutoSize = true;
         this.yLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.yLabel.Location = new System.Drawing.Point(104, 0);
         this.yLabel.Name = "yLabel";
         this.yLabel.Size = new System.Drawing.Size(27, 20);
         this.yLabel.TabIndex = 1;
         this.yLabel.Text = "y :";
         // 
         // xTextBox
         // 
         this.xTextBox.Location = new System.Drawing.Point(56, 2);
         this.xTextBox.Name = "xTextBox";
         this.xTextBox.Size = new System.Drawing.Size(42, 20);
         this.xTextBox.TabIndex = 2;
         // 
         // yTextBox
         // 
         this.yTextBox.Location = new System.Drawing.Point(137, 2);
         this.yTextBox.Name = "yTextBox";
         this.yTextBox.Size = new System.Drawing.Size(42, 20);
         this.yTextBox.TabIndex = 3;
         // 
         // vec2InputView
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.yTextBox);
         this.Controls.Add(this.xTextBox);
         this.Controls.Add(this.yLabel);
         this.Controls.Add(this.xLabel);
         this.Name = "vec2InputView";
         this.Size = new System.Drawing.Size(212, 27);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label xLabel;
      private System.Windows.Forms.Label yLabel;
      private System.Windows.Forms.TextBox xTextBox;
      private System.Windows.Forms.TextBox yTextBox;
   }
}
