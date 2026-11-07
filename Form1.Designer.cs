namespace EstructurasLineales
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstResultados = new ListBox();
            txtDato = new TextBox();
            btnPush = new Button();
            btnPop = new Button();
            button3 = new Button();
            btnEnqueue = new Button();
            btnDequeue = new Button();
            btnPeek = new Button();
            btnEnqueueCircular = new Button();
            btnDequeueCircular = new Button();
            SuspendLayout();
            // 
            // lstResultados
            // 
            lstResultados.FormattingEnabled = true;
            lstResultados.Location = new Point(288, 33);
            lstResultados.Name = "lstResultados";
            lstResultados.Size = new Size(857, 544);
            lstResultados.TabIndex = 0;
            // 
            // txtDato
            // 
            txtDato.Location = new Point(39, 33);
            txtDato.Name = "txtDato";
            txtDato.Size = new Size(175, 35);
            txtDato.TabIndex = 1;
            // 
            // btnPush
            // 
            btnPush.Location = new Point(39, 115);
            btnPush.Name = "btnPush";
            btnPush.Size = new Size(175, 40);
            btnPush.TabIndex = 0;
            btnPush.Text = "Push";
            btnPush.UseVisualStyleBackColor = true;
            btnPush.Click += btnPush_Click;
            // 
            // btnPop
            // 
            btnPop.Location = new Point(39, 191);
            btnPop.Name = "btnPop";
            btnPop.Size = new Size(175, 40);
            btnPop.TabIndex = 0;
            btnPop.Text = "Pop";
            btnPop.UseVisualStyleBackColor = true;
            btnPop.Click += btnPop_Click;
            // 
            // button3
            // 
            button3.Location = new Point(733, 335);
            button3.Name = "button3";
            button3.Size = new Size(8, 8);
            button3.TabIndex = 0;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // btnEnqueue
            // 
            btnEnqueue.Location = new Point(39, 335);
            btnEnqueue.Name = "btnEnqueue";
            btnEnqueue.Size = new Size(175, 40);
            btnEnqueue.TabIndex = 0;
            btnEnqueue.Text = "Enqueue";
            btnEnqueue.UseVisualStyleBackColor = true;
            btnEnqueue.Click += btnEnqueue_Click;
            // 
            // btnDequeue
            // 
            btnDequeue.Location = new Point(39, 400);
            btnDequeue.Name = "btnDequeue";
            btnDequeue.Size = new Size(175, 40);
            btnDequeue.TabIndex = 2;
            btnDequeue.Text = "Dequeue";
            btnDequeue.UseVisualStyleBackColor = true;
            btnDequeue.Click += btnDequeue_Click;
            // 
            // btnPeek
            // 
            btnPeek.Location = new Point(39, 261);
            btnPeek.Name = "btnPeek";
            btnPeek.Size = new Size(175, 43);
            btnPeek.TabIndex = 3;
            btnPeek.Text = "Peek";
            btnPeek.UseVisualStyleBackColor = true;
            btnPeek.Click += btnPeek_Click;
            // 
            // btnEnqueueCircular
            // 
            btnEnqueueCircular.Location = new Point(316, 590);
            btnEnqueueCircular.Name = "btnEnqueueCircular";
            btnEnqueueCircular.Size = new Size(247, 43);
            btnEnqueueCircular.TabIndex = 4;
            btnEnqueueCircular.Text = "Enqueue Circular";
            btnEnqueueCircular.UseVisualStyleBackColor = true;
            btnEnqueueCircular.Click += btnEnqueueCircular_Click;
            // 
            // btnDequeueCircular
            // 
            btnDequeueCircular.Location = new Point(683, 591);
            btnDequeueCircular.Name = "btnDequeueCircular";
            btnDequeueCircular.Size = new Size(247, 41);
            btnDequeueCircular.TabIndex = 5;
            btnDequeueCircular.Text = "Dequeue Circular";
            btnDequeueCircular.UseVisualStyleBackColor = true;
            btnDequeueCircular.Click += btnDequeueCircular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1216, 645);
            Controls.Add(btnDequeueCircular);
            Controls.Add(btnEnqueueCircular);
            Controls.Add(btnPeek);
            Controls.Add(btnDequeue);
            Controls.Add(btnEnqueue);
            Controls.Add(button3);
            Controls.Add(btnPop);
            Controls.Add(btnPush);
            Controls.Add(txtDato);
            Controls.Add(lstResultados);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstResultados;
        private TextBox txtDato;
        private Button btnPush;
        private Button btnPop;
        private Button button3;
        private Button btnEnqueue;
        private Button btnDequeue;
        private Button btnPeek;
        private Button btnEnqueueCircular;
        private Button btnDequeueCircular;
    }
}
