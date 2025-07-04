using Slide6;
using System;
using System.Linq;
using System.Security.Cryptography;

public class Program
{
    public static void Main(string[] args)
    {
        //First khong dieu kien
        //List<string> list = new List<string>() { "1", "2", "3", "haha" };
        //Console.WriteLine(list.Last());
        ////First nhung co dieu kien
        //var intList = new List<int>() { 1, 2, 3, 4,2,-99 };
        //Console.WriteLine(intList.LastOrDefault(x => x > 5));
        //Console.WriteLine("hihhahaia");

        
        //var intList = new List<int>() { 1};
        //Console.WriteLine(intList.Single());
        //var stringList = new List<string>() { "T1", "T2", "T3", "T4", "T1" };
        //Console.WriteLine(stringList.SingleOrDefault(x => x.CompareTo("T1") == 0));

        //var intList = new List<int>();
        //var check = intList.DefaultIfEmpty(-1);
        //Console.WriteLine(intList.Count);
        //Console.WriteLine(check.ElementAt(0));
        
        //Console.WriteLine(check.ElementAt(1));
        //Console.WriteLine(check.ElementAt(2));

        var listProduct = new List<Product>();
        listProduct.Add(new Product(1, "ao batman", 100, "ao ba lo"));
        listProduct.Add(new Product(2, "ao nguoi doi", 110, "ao t-shirt"));
        listProduct.Add(new Product(1, "ao nguoi chuon chuon", 120, "ao khoac"));
        listProduct.Add(new Product(2, "ao nguoi nhen", 1, "ao len"));

        var listBrand = new List<Brand>();
        listBrand.Add(new Brand(1, "nike"));
        listBrand.Add(new Brand(2, "ysl"));

        var result = listBrand.Join(listProduct,
            brand => brand.id,
            product => product.brandId,
            (brand, product) => new
            {
                brand.id,
                brand.brandName,
                product.price,
                product.description,
            });
        foreach (var item in result)
        {
            Console.WriteLine($"ID: {item.id} \t Brand: {item.brandName}" +
                $" \t Price: {item.price} \t Description: {item.description}");
        }
        Console.WriteLine("------------------------------------------");

        var leftJoinResult = from product in listProduct // tu product trong listProduct
                     join brand in listBrand // hop voi brand trong listBrand
                     on product.brandId equals brand.id // dua vua dieu kien product.id = brand.id
                     into res // tao thanh res
                     from item in res.DefaultIfEmpty() // tu item trong res
                     select // lay ra
                     new // 1 kieu du lieu moi
                     {
                         id = product.brandId,
                         price = product.price,
                         des = product.description,
                         brand = item?.brandName
                     };
        foreach (var item in leftJoinResult)
        {
            Console.WriteLine($"ID: {item.id} \t Brand: {item.brand}" +
                $" \t Price: {item.price} \t Description: {item.des}");
        }

        Console.WriteLine("------------------------------------------");
        var groupJoinResult = listBrand.GroupJoin(listProduct,
            brand => brand.id,
            product => product.brandId,
            (brand, product) => new
            {
                brand,
                product
            });
        foreach (var item in groupJoinResult)
        {
            Console.WriteLine($"ID: {item.brand.id} \t Brand: {item.brand.brandName}");
            foreach (var product in item.product)
            {
                Console.WriteLine( $" \t Price: {product.price} \t Description: {product.description}");
            }
        }
        Console.WriteLine("------------------------------------------");
        var listInt = new List<int>() { 1,1,1,1,1,2,2,2,2,344,5,6,1};
        var listDistinct= listInt.Distinct();
        foreach(var item in listDistinct)
        {
            Console.WriteLine(item);
        }
        var daySo = new[] {1,2,3,4,5,6,7,8 };
        //Sử dụng linQ aggregate
        //bài 1.Viết hàm để tính tổng lũy kế của tất cả các phần tử trong daySo
        // vd: 1 + 2 + 3 + ... +8

        //bài 2.Viết hàm để tính tổng lũy kế của tất cả các phần tử trong daySo
        // vd: 1 ^ 2 + 2 ^ 2 + 3 ^ 2 + ... +8 ^ 2

        //bài 3.Viết hàm để tính tích lũy kế tất cả các phần tử trong daySo
        // vd: 1 * 2 * 3 * ... *8

        //bài 4.Viết hàm để tính tích lũy kế tất cả các phần tử trong dayso mà phần tử đó là số chia hết cho 3
        // vd: 3 * 6

        var dayThanhPho = new[] {"ha noi", "ho chi minh", "cao bang",
            "lao cai", "thanh hoa", "nghe an", "can tho", "soc trang",
            "ha tien", "ha nam", "ha tay", "ha nam ninh"};
        //bài 5.Viết hàm để lấy ra tất cả các thành phố có độ dài tên lớn hơn 6

        //bài 6.Viết hàm để lấy ra tất cả các thành phố có tên bắt đầu bằng chữ h


        //bài 7.Viết hàm lấy ra tất cả các thành phố có độ dài tên lớn hơn 6,
        //tên bắt đầu bằng chữ h và sắp xếp theo thứ tự tăng dần


        var a = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        var productRes = a.Where(a => a % 3 == 0).Aggregate((a, b) => a * b);
        Console.WriteLine(productRes);

        

    }
}