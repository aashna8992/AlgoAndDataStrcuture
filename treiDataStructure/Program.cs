using System;
using treiDataStructure;
using static treiDataStructure.Trie;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

	// Input keys (use only 'a'
	// through 'z' and lower case)
	String[] keys = {"the", "a", "there", "answer",
						"any", "by", "bye", "their"};

	String[] output = { "Not present in trie", "Present in trie" };


	root = new TrieNode();

	// Construct trie
	int i;
	for (i = 0; i < keys.Length; i++)
		insert(keys[i]);

	// Search for different keys
	if (search("the") == true)
		Console.WriteLine("the --- " + output[1]);
	else Console.WriteLine("the --- " + output[0]);

	if (search("these") == true)
		Console.WriteLine("these --- " + output[1]);
	else Console.WriteLine("these --- " + output[0]);

	if (search("their") == true)
		Console.WriteLine("their --- " + output[1]);
	else Console.WriteLine("their --- " + output[0]);

	if (search("thaw") == true)
		Console.WriteLine("thaw --- " + output[1]);
	else Console.WriteLine("thaw --- " + output[0]);




// C# implementation of search and
// insert operations on Trie



	// Driver

/* This code contributed by PrinciRaj1992 */
