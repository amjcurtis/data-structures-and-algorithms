package main

import (
	"fmt"
)

// Custom type for boxing and unboxing strings
// since you can't declare methods for non-user-defined types
type myString string

// Reverses copy of string value in place
func reverseString(s string) string {
	letters := []rune(s)

	for i, j := 0, len(letters)-1; i < j; i, j = i+1, j-1 {
		letters[i], letters[j] = letters[j], letters[i]
	}

	return string(letters)
}

// Method on custom named type to reverse value type
func (s myString) reverse() myString {
	letters := []rune(s)

	for i, j := 0, len(letters)-1; i < j; i, j = i+1, j-1 {
		letters[i], letters[j] = letters[j], letters[i]
	}

	return myString(letters)
}

func main() {
	// Demo reverseString function
	str := "supercalifragilisticexpialidocious"
	fmt.Printf("%s (str original)\n", str)                     // Show original string
	fmt.Printf("%s (str copy reversed)\n", reverseString(str)) // Print reversed copy of string
	fmt.Printf("%s (str original unmutated)\n", str)           // Show original string hasn't been mutated
	fmt.Println()

	// Demo reverse method
	newStr := myString(str)
	fmt.Printf("%s (newStr original)\n", newStr)
	fmt.Printf("%s (newStr copy reversed)\n", newStr.reverse())
	fmt.Printf("%s (newStr original unmutated)\n", newStr)
	fmt.Printf("newStr (unboxed as %T)", string(newStr))
}
