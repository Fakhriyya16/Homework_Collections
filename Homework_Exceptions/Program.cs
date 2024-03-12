
using Homework_Exceptions.Controllers;
using Homework_Exceptions.Datas;
using Homework_Exceptions.Helpers.Exceptions;
using Homework_Exceptions.Services;
#region OldHomework(Exceptions)
//void Calculate()
//{
//    bool isCorrectCalculate = true;
//    try 
//    {
//        int a = 5;
//        int b = 0;
//        var result = a / b;
//        //Console.WriteLine(result);

//        int[] arr = { 1, 2, 3 };

//        //arr[5] = 10;
//    } 
//    catch (Exception ex)
//    {
//        isCorrectCalculate = false;
//    }
//    finally 
//    {
//        SendMessage(isCorrectCalculate);
//    }
//}

////Calculate();

//void SendMessage(bool isCorrectCalculate)
//{
//    if (isCorrectCalculate)
//    {
//        Console.WriteLine("Your message is sent successfully");
//    }
//    else
//    {
//        Console.WriteLine("Your message failed");
//    }
//}

//string GetById(int? id)
//{
//    try
//    {
//        if (id == null)
//        {
//            //throw new ArgumentNullException("id");

//            throw new CustomArgumentNullException("Argument cannot be null");
//        }


//        //ArgumentNullException.ThrowIfNull(id);

//        return "Finish";
//    }
//    catch (Exception ex)
//    {
//        return ex.Message;
//    }
//}

////Console.WriteLine(GetById(null));

////------------------------------------------------------------------------------------------------------

//// Ededin faktorilalini tapan method yazmaq. Eger menfi eded daxil edilibse custom exception cixarsin.
//int num;

////Console.WriteLine("Add your input:");

//bool convertSuccessfull = int.TryParse(Console.ReadLine(), out num);

//void FactorialOfNumbers(int num)
//{
//    try
//    {
//        if (convertSuccessfull)
//        {
//            if (num >= 0)
//            {
//                int factorial = 1;
//                for (int i = 1; i <= num; i++)
//                {
//                    factorial *= i;
//                }
//                Console.WriteLine(factorial);
//            }
//            else
//            {
//                throw new NegativeInputException("Input cannot be negative");
//            }
//        }
//        else
//        {
//            throw new ArgumentNullException("num", "Input cannot be null");
//        }
//    }
//    catch (NegativeInputException ex)
//    {
//        Console.WriteLine(ex.Message);
//    }
//    catch(ArgumentNullException ex)
//    {
//        Console.WriteLine(ex.Message);
//    }
//}

//FactorialOfNumbers(num);

//--------------------------------------------------------------------------------------------------------

//Login ucun custom exception yazib isdifade etmek. Eger email ve yaxud password sehvdirse custom exception
//istifade edin. Models, Services, Controller folderleriniz olacaq. Service mentiqi ile yazirsiz. 

//Bir custom exception classi yaradin. Login olan zaman passwordun simvollarinin sayi 6-dan kicikdirse
//exception cixarsin. 


//AccountController accountController = new AccountController();

//accountController.SignIn();

#endregion


//foreach(var item in AppDbContext.customers)
//{
//    Console.WriteLine(item.FullName);
//}

CustomerController customerController = new CustomerController();

//customerController.GetAll();

//customerController.GetById();

//customerController.GetAllByAge();

//customerController.GetCount();

//customerController.OrderByAge();














