//C#

s.Substring(int startIndex)
s.Substring(int startIndex, int Length)

Char.IsDigit(char c)


//Dictionary
var dict = new Dictionary<int, int>();
dict.Add(key, value);

var pairs = dict.ToList();

pairs.Sort(Comparer<KeyValuePair<string, int>>.Create((p1, p2) => {
            
                if (p1.Value == p2.Value)
                    return p1.Key.CompareTo(p2.Key);
                return p1.Value > p2.Value? -1: 1;
            }));
var topK = pairs.Take(k).Select(x => x.Key);


Stack:
var stack = new Stack<int>();
Peek()
Push()
Pop()


//List:
IList list = new List<int>();
list.Add(2);
list.Insert(index, element);
List.

//Array
Array.Sort(arr) 
arr.OrderByDescending(c => c).ToArray(); 


//StringBuilder
Append(string s)
Append(char c)

//LinkedList
RemoveFirst()
RemoveLast()
Node AddFirst(node)
Node AddLast(node)

.First
.Last

//Convert string to int
Convert.ToInt32(string, base)


Out vs ref
int G;
Sum(out G);

Public int Sum(out int G) {
}

//Ref:
string str = "Geek"; 
SetValue(ref str); 
static void SetValue(ref string str1) {
}




