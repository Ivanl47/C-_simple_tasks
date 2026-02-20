
static void first(){
    Console.WriteLine("введіть перше число");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введіть друге число");
    int number2 = Convert.ToInt32(Console.ReadLine());
    if(number > number2){
        Console.Writeline(number - number2);
    }
    else if(number < number2){
        Console.Writeline(number2 + number);
    }
    else{
        Console.Writeline(0);
    }
}

static void second(){
    Console.WriteLine("введіть число");
    int n = Convert.ToInt32(Console.ReadLine());
    int sum = 0;
    if(n>0){
        for(int i = 1; i <= n; i++){
            if(n % 2 == 0){
                Console.WriteLine(n);
                sum += i;
            }
        }
    }
}

static void third(){
    int arr = new int[10];
    int count = 0;
    Console.WriteLine("введіть 10 чисел");
    for(int i = 0; i < arr.Length; i++){
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    for(int i = 0; i < arr.Length; i++){
        if(arr[i] < 0){
            count++;
        }
    }
    Console.WriteLine("кількість від'ємних чисел: " + count);
}

static void fourth(int n){
    int arr = new int[n];
    int negative = new int[,];
    Console.WriteLine("введіть " + n + " чисел");
    for(int i = 0; i < arr.Length; i++){
        arr[i] = Convert.ToInt32(Console.ReadLine()); // 1 2 3 4 5 6 7 8 9 10
    }
    for(int i = 0; i < arr.Length; i++){
        if(arr[i] < 0){ 
            negative.Append(arr[i]);
            arr[i] = 0;
        }
    }
    Console.WriteLine("масив з від'ємними числами: " + string.Join(", ", negative));
}

static void fifth(){
    int double_arr = new int[3, 3];
    int lowest = double_arr[0, 0];
    Console.WriteLine("введіть 9 чисел");
    for(int i = 0; i < 3; i++){
        for(int j = 0; j < 3; j++){
            double_arr[i, j] = Convert.ToInt32(Console.ReadLine());
                if(double_arr[i, j] < lowest){
                    lowest = double_arr[i, j];
                }
        }    
    }
    int sum = double_arr[0, 0] + double_arr[1, 1] + double_arr[2, 2];
    Console.WriteLine("сума діагональних елементів: " + sum);
}

static void sixth(int n, int m){
    int double_arr = new int [n, m];
    int odd_count = 0;
    int even_count = 0;
    Console.WriteLine("введіть " + n * m + " чисел");
    for(int i = 0; i < n; i++){ 
        for(int j = 0; j < m; j++){
            double_arr[i, j] = Convert.ToInt32(Console.ReadLine());
            if(double_arr[i, j] % 2 == 0){
                even_count++;
            }
            else{
                odd_count++;
            }
        }
    }
    Console.WriteLine("кількість парних чисел: " + even_count);
    Console.WriteLine("кількість непарних чисел: " + odd_count);
}