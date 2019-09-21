package main

import "testing"

func TestReverseString(t *testing.T) {
	str := "word"
	got := reverseString(str)
	if want := "drow"; got != want {
		t.Errorf("reverseString(%s) = %s; want %s", str, got, want)
	}
}

func TestReverse(t *testing.T) {
	myStr := myString("text")
	got := myStr.reverse()
	if want := myString("txet"); got != want {
		t.Errorf("%s.reverse() = %s; want %s", myStr, got, want)
	}
}
