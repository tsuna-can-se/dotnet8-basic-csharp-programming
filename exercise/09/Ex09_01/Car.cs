namespace Ex09_01
{
    public class Car
    {
        private int gasAmount;

        public void Drive()
        {
            if (this.gasAmount >= 10)
            {
                // ガソリンの残量が10リットル以上ある場合、ガソリンの残量を10リットル減らします。
                // またコンソールに「車を運転しました。ガソリンの残量は##リットルです。」というメッセージを表示します。
                this.gasAmount -= 10;
                Console.WriteLine("車を運転しました。ガソリンの残量は" + this.gasAmount + "リットルです。");
            }
            else
            {
                // ガソリンの残量が10リットル未満の場合、ガソリンの残量を0リットルにします。
                // またコンソール「ガス欠になりました。」というメッセージを表示します。
                this.gasAmount = 0;
                Console.WriteLine("ガス欠になりました。");
            }
        }

        public int Refill(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("給油量は0リットルより大きい値を指定してください。");
                return 0;
            }

            // 実際に給油できる量
            int actualAmount;
            int tempGasAmount = this.gasAmount + amount;
            if (tempGasAmount <= 50)
            {
                // 給油後のガソリン残量が50リットル以下の場合は、指定された数量をそのまま給油します。
                actualAmount = amount;
            }
            else
            {
                // 給油後のガソリン残量が51リットル以上の場合は、50リットルを超える分、指定された数量から差し引いて給油します。
                actualAmount = amount - (tempGasAmount - 50);
            }

            this.gasAmount += actualAmount;
            Console.WriteLine(amount + "リットル給油しようとしました。ガソリンの残量は" + this.gasAmount + "リットルです。");
            return actualAmount;
        }
    }
}
