int a = 10;
int b = 10;
int c = 20;

// 等値（値型）
Console.WriteLine("等値（値型）");
Console.WriteLine(a == b);   // true
Console.WriteLine(a == c);   // false

// 非等値（値型）
Console.WriteLine("非等値（値型）");
Console.WriteLine(a != b);   // false
Console.WriteLine(a != c);   // true

object x = new object();
object y = x;
object z = new object();

// 等値（参照型）
Console.WriteLine("等値（参照型）");
Console.WriteLine(x == y);   // true
Console.WriteLine(x == z);   // false

// 非等値（参照型）
Console.WriteLine("非等値（参照型）");
Console.WriteLine(x != y);   // false
Console.WriteLine(x != z);   // true

string str1 = "dummy text";
string str2 = "dummy text";
string str3 = "hoge text";

// 等値（string型）
Console.WriteLine("等値（string型）");
Console.WriteLine(str1 == str2); // true;
Console.WriteLine(str1 == str3); // false;

// 非等値（string型）
Console.WriteLine("非等値（string型）");
Console.WriteLine(str1 != str2); // false;
Console.WriteLine(str1 != str3); // true;
