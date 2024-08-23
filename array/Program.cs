// This is a particularly difficult challenge. You will need to combine many of the concepts you learned in this exercise, including the use of the Split(), ToCharArray(), Array.Reverse(), and String.Join(). You'll also need to create multiple arrays, and at least one iteration statement.
// ehT kciuq nworb xof spmuj revo eht yzal god

string pangram = "The quick brown fox jumps over the lazy dog";

string[] pangramSplit = pangram.Split(" ");
string result = "";

foreach (string word in pangramSplit)
{
    char[] wordArray = word.ToCharArray();
    Array.Reverse(wordArray);
    string rebuildWord = string.Join("", wordArray);
    result += rebuildWord + " ";
}
result=result.Trim();
System.Console.WriteLine(result);

// Step 1
string[] message = pangram.Split(' ');

//Step 2
string[] newMessage = new string[message.Length];

// Step 3
for (int i = 0; i < message.Length; i++)
{
    char[] letters = message[i].ToCharArray();
    Array.Reverse(letters);
    newMessage[i] = new string(letters);
}

//Step 4
string result1 = String.Join(" ", newMessage);
Console.WriteLine(result1);