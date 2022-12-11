int num = 0;
int price = 0;
double GST = 0;
double QST = 0;
int count = 0;
double totalGST = 0;
double totalQST = 0;
do{
    Console.Write("Please eneter the number of items bought [1...10]: ");
    num = Convert.ToInt32(Console.ReadLine());
    if(num >= 1 && num <= 10){
        break;
    }else{
        count++;
    }
}while(num >= 1 || num <= 10);

int[] arrPrice = new int[num];
for(int i = 0; i < num; i++){
    do{
        Console.Write($"Please eneter the price of items {i + 1} [1...1000]: ");
        price = Convert.ToInt32(Console.ReadLine());
        if(price >= 1 && price <= 1000){
            arrPrice[i] = price;
            break;
        }else{
            count++;
        }
    }while(price >= 1 || price <= 1000);
}

do{
    Console.Write("Please eneter the tax rate of GST in % [0...14]: ");
    GST = Convert.ToDouble(Console.ReadLine());
    double[] arrGST = new double[num];
    if(GST >= 0 && GST <= 14){
        totalGST = GST * num;
        break;
    }else{
        count++;
        }
}while(GST >= 0 || GST <= 14);

do{
    Console.Write("Please eneter the tax rate of QST in % [0...14]: ");
    QST = Convert.ToDouble(Console.ReadLine());
    double[] arrGST = new double[num];
    if(QST >= 0 && QST <= 17){
        totalQST = QST * num;
        break;
    }else{
        count++;
        }
}while(QST >= 0 || QST <= 17);

Console.WriteLine($"You have entered {count} invalid inputs.");
Console.Write("Sub Total: $");
int subTotal = 0;
for(int i = 0; i < num; i++){
    subTotal += arrPrice[i];
}
Console.Write(subTotal + "\n");

Console.WriteLine($"GST: ${totalGST}");
Console.WriteLine($"GST: ${totalQST}");
double total = 0;
total = subTotal + GST + QST;
Console.WriteLine($"Total: ${total}");