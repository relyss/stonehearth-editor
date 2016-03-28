namespace StonehearthEditor
{
   partial class EffectsBuilderView
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
         this.effectsBuilderPanel = new System.Windows.Forms.FlowLayoutPanel();
         this.btnSave = new System.Windows.Forms.Button();
         this.pnlEditor = new System.Windows.Forms.Panel();
         this.SuspendLayout();
         // 
         // effectsBuilderPanel
         // 
         this.effectsBuilderPanel.AutoScroll = true;
         this.effectsBuilderPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
         this.effectsBuilderPanel.Location = new System.Drawing.Point(267, 402);
         this.effectsBuilderPanel.Name = "effectsBuilderPanel";
         this.effectsBuilderPanel.Size = new System.Drawing.Size(145, 161);
         this.effectsBuilderPanel.TabIndex = 0;
         // 
         // btnSave
         // 
         this.btnSave.Location = new System.Drawing.Point(3, 3);
         this.btnSave.Name = "btnSave";
         this.btnSave.Size = new System.Drawing.Size(74, 29);
         this.btnSave.TabIndex = 1;
         this.btnSave.Text = "Save";
         this.btnSave.UseVisualStyleBackColor = true;
         // 
         // pnlEditor
         // 
         this.pnlEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.pnlEditor.AutoScroll = true;
         this.pnlEditor.Location = new System.Drawing.Point(3, 38);
         this.pnlEditor.Name = "pnlEditor";
         this.pnlEditor.Size = new System.Drawing.Size(371, 535);
         this.pnlEditor.TabIndex = 2;
         // 
         // EffectsBuilderView
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.pnlEditor);
         this.Controls.Add(this.btnSave);
         this.Controls.Add(this.effectsBuilderPanel);
         this.Name = "EffectsBuilderView";
         this.Size = new System.Drawing.Size(431, 576);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.FlowLayoutPanel effectsBuilderPanel;
      private System.Windows.Forms.Button btnSave;
      private System.Windows.Forms.Panel pnlEditor;
   }
}
