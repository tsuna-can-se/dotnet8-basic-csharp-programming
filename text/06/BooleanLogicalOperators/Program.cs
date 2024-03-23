// 論理否定（NOT）
Console.WriteLine("論理否定（NOT）");
Console.WriteLine(!true);  // false
Console.WriteLine(!false); // true

// 論理AND
Console.WriteLine("論理AND");
Console.WriteLine(true & true);   // true
Console.WriteLine(true & false);  // false
Console.WriteLine(false & true);  // false
Console.WriteLine(false & false); // false

// 論理OR
Console.WriteLine("論理OR");
Console.WriteLine(true | true);   // true
Console.WriteLine(true | false);  // true
Console.WriteLine(false | true);  // true
Console.WriteLine(false | false); // false

// 論理排他的OR（XOR）
Console.WriteLine("論理排他的OR（XOR）");
Console.WriteLine(true ^ true);   // false
Console.WriteLine(true ^ false);  // true
Console.WriteLine(false ^ true);  // true
Console.WriteLine(false ^ false); // false

// 条件付き論理AND
Console.WriteLine("条件付き論理AND");
Console.WriteLine(true && true);   // true
Console.WriteLine(true && false);  // false
Console.WriteLine(false && true);  // false
Console.WriteLine(false && false); // false

// 条件付き論理OR
Console.WriteLine("条件付き論理OR");
Console.WriteLine(true || true);   // true
Console.WriteLine(true || false);  // true
Console.WriteLine(false || true);  // true
Console.WriteLine(false || false); // false
