// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец,
// на пересечении которых расположен наименьший элемент массива. 
// Например, задан массив: НЕ СДЕЛАНА
// 1 4 7 2 
// 5 9 2 3 
// 8 4 2 4 
// 5 2 6 7 
// Наименьший элемент - 1, на выходе получим 
// следующий массив: 
// 9 4 2 
// 2 2 6 
// 3 4 7


// полужу здесь функ Аккермана
// int Ack(TreeNode tn, int n, int m)
//         {
//             if (tek_step > 2000) return 0;
//             TreeNode tek_tn = tn.Nodes.Add(String.Format("{0},{1}", n, m));

//             int val=0;

//             if (n == 0)
//             {
//                 val = m + 1;
//             }
//             else if (m == 0)
//             {
//                 val = Ack(tek_tn,n - 1, 1);
//             }
//             else
//             {
//                 val = Ack(tek_tn,n - 1, Ack(tek_tn,n, m - 1));
//             }
//          tek_tn.Text = String.Format("{0},{1}={2}", n, m,val);
//           return val;
//         }

//          void button124_Click(object sender, EventArgs e)
//         {
//             TreeNode tn = treeView2.Nodes.Add("Start");
//             textBox3.Text = Ack(tn, int.Parse(textBox1.Text), int.Parse(textBox2.Text)).ToString();

//         }


        private double getValue(int n, int i=1)
{
       if (i==1)
      return n/Math.Sqrt(i+getValue(n,i+1));
       else 
{
       if (i!=n)
 return Math.Sqrt(i+getValue(n,i+1));
          else return Math.Sqrt(n);
}
}
