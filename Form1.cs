namespace EstructurasLineales
{
    public partial class Form1 : Form
    {
        // ==========================================
        // 1. PILA ESTÁTICA (STACK)
        // ==========================================
        private int[] pila = new int[5];
        private int top = -1;

        // Métodos de validación explícitos (Instrucción 1)
        private bool IsEmptyPila() => top == -1;
        private bool IsFullPila() => top == pila.Length - 1;

        // ==========================================
        // 2. COLA SIMPLE ESTÁTICA
        // ==========================================
        private int[] colaSimple = new int[5];
        private int frontSimple = 0;
        private int rearSimple = -1;

        // ==========================================
        // 3. COLA CIRCULAR ESTÁTICA (Instrucción 2)
        // ==========================================
        private int[] colaCircular = new int[5];
        private int frontCircular = -1;
        private int rearCircular = -1;
        private int contadorCircular = 0;

        public Form1()
        {
            InitializeComponent();
        }

        // ------------------------------------------
        // OPERACIONES DE LA PILA
        // ------------------------------------------
        private void btnPush_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDato.Text, out int valor))
            {
                if (!IsFullPila())
                {
                    top++;
                    pila[top] = valor;
                    lstResultados.Items.Add($"[PILA] Push({valor}): Elemento insertado en top={top}");
                    txtDato.Clear();
                    txtDato.Focus();
                }
                else
                {
                    MessageBox.Show("¡Pila Llena! (isFull() = true / Stack Overflow)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Ingresa un número entero válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            if (!IsEmptyPila())
            {
                int eliminado = pila[top];
                top--;
                lstResultados.Items.Add($"[PILA] Pop(): Extraído {eliminado}, nuevo top={top}");
            }
            else
            {
                MessageBox.Show("¡Pila Vacía! (isEmpty() = true / Underflow)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            if (!IsEmptyPila())
            {
                lstResultados.Items.Add($"[PILA] Peek(): Elemento en la cima es {pila[top]}");
                MessageBox.Show($"Cima de la Pila: {pila[top]}", "Peek", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("La pila está vacía (isEmpty() = true).", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ------------------------------------------
        // OPERACIONES DE LA COLA SIMPLE
        // ------------------------------------------
        private void btnEnqueue_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDato.Text, out int valor))
            {
                if (rearSimple < colaSimple.Length - 1)
                {
                    rearSimple++;
                    colaSimple[rearSimple] = valor;
                    lstResultados.Items.Add($"[COLA SIMPLE] Enqueue({valor}): rear={rearSimple}");
                    txtDato.Clear();
                    txtDato.Focus();
                }
                else
                {
                    MessageBox.Show("¡Cola Simple Llena! (Queue Overflow)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Ingresa un número entero válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDequeue_Click(object sender, EventArgs e)
        {
            if (frontSimple <= rearSimple)
            {
                int atendido = colaSimple[frontSimple];
                lstResultados.Items.Add($"[COLA SIMPLE] Dequeue(): Se atendió {atendido} de front={frontSimple}");
                frontSimple++;

                if (frontSimple > rearSimple)
                {
                    frontSimple = 0;
                    rearSimple = -1;
                }
            }
            else
            {
                MessageBox.Show("¡Cola Simple Vacía! (Queue Underflow)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ------------------------------------------
        // OPERACIONES DE LA COLA CIRCULAR
        // ------------------------------------------
        private void btnEnqueueCircular_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDato.Text, out int valor))
            {
                if (contadorCircular < colaCircular.Length)
                {
                    if (frontCircular == -1) frontCircular = 0;
                    rearCircular = (rearCircular + 1) % colaCircular.Length;
                    colaCircular[rearCircular] = valor;
                    contadorCircular++;

                    lstResultados.Items.Add($"[CIRCULAR] Enqueue({valor}): front={frontCircular}, rear={rearCircular}");
                    txtDato.Clear();
                    txtDato.Focus();
                }
                else
                {
                    MessageBox.Show("¡Cola Circular Llena!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Ingresa un número entero válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDequeueCircular_Click(object sender, EventArgs e)
        {
            if (contadorCircular > 0)
            {
                int atendido = colaCircular[frontCircular];
                lstResultados.Items.Add($"[CIRCULAR] Dequeue(): Atendido {atendido} de front={frontCircular}");
                frontCircular = (frontCircular + 1) % colaCircular.Length;
                contadorCircular--;

                if (contadorCircular == 0)
                {
                    frontCircular = -1;
                    rearCircular = -1;
                }
            }
            else
            {
                MessageBox.Show("¡Cola Circular Vacía!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
