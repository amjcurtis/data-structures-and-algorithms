package main

import "testing"

func TestReverseString(t *testing.T) {
	str := "word"
	got := reverseString(str)
	want := "drow"
	if got != want {
		t.Errorf("reverseString(%s) = %s; want %s", str, got, want)
	}
}
