namespace Learnging
{
    public class Sorting
    {
        int[] arry;
        public Sorting(int[] x)
        {
             this.arry = x;
        }
        public int[] bubbleSort()
        {
            int temp;
            for (int i = 0; i < this.arry.Length; i++)
            {
                for (int j = i + 1; j < this.arry.Length; j++)
                {
                    if (this.arry[i] > this.arry[j])
                    {
                        temp = this.arry[i];
                        this.arry[i] = this.arry[j];
                        this.arry[j] = temp;
                    }
                }
            }
            return this.arry;
        }
        public void print()
        {
            for (int i = 0; i < this.arry.Length; i++)
            {
                Console.WriteLine(this.arry[i]);
            }
        }
    }
    
}
