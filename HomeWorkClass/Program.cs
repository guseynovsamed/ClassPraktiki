


using HomeWorkClass;
using HomeWorkClass.Models;
using System.Diagnostics;

//Employee employee = new()
//{
//    fullName = "Semed Huseynov",
//    address = "Ehmedli",
//    age = 26
//};

//Console.WriteLine(employee.GetFullData());



//Employee employee = new()
//{
//    fullName = "Semed Huseynov",
//    age = 30,

//};

//Console.WriteLine(employee.GetFullData());



//Employee employee1 = new()
//{
//    fullName = "Semed Huseynov",
//    address = "Ehmedli",
//    age = 27

//};

//Employee employee2 = new()
//{
//    fullName = "Oruc Mehrabov",
//    address = "Yasamal",
//    age = 26

//};

//Employee employee3 = new()
//{
//    fullName = "Ilham Abasli",
//    address = "Lokbatan",
//    age = 19

//};


//Employee[] employees = {employee1, employee2, employee3};

//foreach (Employee item in employees)
//{
//    Console.WriteLine(item.GetFullData());
//}


//Book book = new(50 , "Qarabag");


//book.name = "Isgendername";
//book.author = "Nizami";

//Console.WriteLine(book.GetData());



//User user1 = new()
//{
//    id = 1,
//    fullName = "Aqshin Valiyev",
//    age = 24

//};


//User user2 = new()
//{
//    id =2,
//    fullName="Haci Ehmedov",
//    age = 28
//};


//User user3 = new()
//{
//    id = 3,
//    fullName = "Metanet Abbasov",
//    age = 25

//};



//User user4 = new()
//{
//    id = 4,
//    fullName = "Meryem Eliyeva",
//    age = 23

//};


//User[] people = { user1, user2, user3, user4 };


//foreach ( var person in people)
//{
//    Console.WriteLine(person.fullName);

//}



//foreach ( var person in people)
//{
//    if (person.id ==3)
//    {
//        Console.WriteLine(person.fullName);
//        break;
//    }
//}



//var result = people.Where(m => m.id > 2).ToArray();

//foreach (var item in result)
//{
//    Console.WriteLine(item.fullName);
//}


//var result = Array.FindAll(people, m => m.id > 1);


//foreach ( var item in result)
//{
//    Console.WriteLine(item.fullName);
//}




//var result = GetAllUsers();

//foreach(var item in result)
//{
//    Console.WriteLine(item.fullName);
//}


//static void ShowUser()
//{
//    var result = GetAllUsers();

//    foreach (var item in result)
//    {
//        Console.WriteLine(item.fullName);
//    }


//}


//static User[] GetAllUsers()
//{

//    User user1 = new()
//    {
//        id = 1,
//        fullName = "Aqshin Valiyev",
//        age = 24

//    };


//    User user2 = new()
//    {
//        id = 2,
//        fullName = "Haci Ehmedov",
//        age = 28
//    };


//    User user3 = new()
//    {
//        id = 3,
//        fullName = "Metanet Abbasov",
//        age = 25

//    };



//    User user4 = new()
//    {
//        id = 4,
//        fullName = "Meryem Eliyeva",
//        age = 23

//    };



//    User[] people = { user1, user2, user3, user4 };


//    return people;
//}


//ShowUser();



//UserService service = new();

////service.ShowUser();

//User user = service.GetUserById(3);

//Console.WriteLine(user.fullName);


static void SearchByName(string searchText)
{
    Product[] products = GetAllProducts();


    Product[] products = GetAllProducts;


    Product exsisProduct = products.FirstOrDefault(m => m.name.Trim().ToLower().Contains(searchText));

    if (exsisProduct == null)
    {
        Console.WriteLine("NotFoud");
        return;
    }




    bool isExist = false;

    if(searchText== " ")
    {
        Console.WriteLine("Please add seaech text ");
    }


    foreach (var product in products)
    {
        if (product.name.Trim().ToLower().Contains(searchText.Trim().ToLower()))
        {
            Console.WriteLine($"{ product.id}-{ product.name}-{ product.price}{ product.count}");
            isExist = true;
        }
        else
        {
            isExist = false;
        }
    } 


}

Console.WriteLine("Add search text:");

string searchText = Console.ReadLine();

SearchByName(searchText);




static Product[] GetAllProducts()
{
    Product product1 = new()
    {
        id = 1,
        name = "Iphone",
        price = 1200,
        count = 3
    };
    Product product2 = new()
    {
        id = 2,
        name = "Samsung",
        price = 1000,
        count = 32
    };
    Product product3 = new()
    {
        id = 3,
        name = "Motorolo",
        price = 300,
        count = 3
    };
    Product product4 = new()
    {
        id = 4,
        name = "Nokia",
        price = 300,
        count = 9
    };


    Product[] products = {product1 ,  product2 , product3 , product4 };  

    return products;
}