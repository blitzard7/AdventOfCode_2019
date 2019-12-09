namespace AdventOfCode.Puzzles
{
    public class IntCode
    {
        private bool _running;
        private int _firstParam = 1;
        private int _secondParam = 2;
        private int _resultIndex = 3;

        public IntCode(int[] data)
        {
            this.Data = data;
            _running = true;    
        }

        public int[] Data { get; }

        public int Add(int first, int second) => first + second;

        public int Multiply(int first, int second) => first * second;

        public void Start()
        {
            this.ReplaceValues();
            while (_running)
            {
                this.ReadOpCode();
            }
        }

        public void Halt()
        {
            _running = false;
        }

        public void ReadOpCode()
        {
            for (int i = 0; i < this.Data.Length; i++)
            {
                var instruction = this.Data[i];

                if (instruction == (int)OpCode.Halt)
                {
                    this.Halt();
                    return;
                }

                var first = GetValueAtIndex(this.Data[_firstParam]);
                var second = GetValueAtIndex(this.Data[_secondParam]);
                var rIndex = this.Data[_resultIndex];

                switch (this.Data[i])
                {
                    case (int)OpCode.Add:
                        this.Data[rIndex] = Add(first, second); ;
                        break;

                    case (int)OpCode.Multiply:
                        this.Data[rIndex] = Multiply(first, second); ;
                        break;
                    default:
                        continue;
                }

                this.AdaptInstructionPointer();
                i += 3;
            }
        }

        private int GetValueAtIndex(int index) => this.Data[index];

        private void AdaptInstructionPointer()
        {
            const int incrementer = 4;
            _firstParam += incrementer;
            _secondParam += incrementer;
            _resultIndex += incrementer;
        }

        private void ReplaceValues()
        {
            this.Data[1] = 12;
            this.Data[2] = 2;
        }
    }
}
