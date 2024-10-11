﻿Public Class Form1
    'ARRAY NOTES

    'Learning Goals
    '---------------
    'I can create and use arrays to solve problems in Visual BASIC
    'I can use loops to process all the elements of an array
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'What is an array?
        ListBox1.Items.Add("An ARRAY is a variable that can hold a list of information")

        ListBox1.Items.Add("Examples:")
        ListBox1.Items.Add(" - Grocery List")
        ListBox1.Items.Add(" - Your grades in a class")
        ListBox1.Items.Add(" - A list of the states and capitals for a trivia game")

        'How do I make an array that holds 5 elements?


        'testScores = [0, 0, 0, 0, 0]
        '      index:  0  1  2  3  4

        'The INDEX number identifies the location in the array
        'We can use this index number to access/change array elements

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'Accessing Array Elements
        Dim testScores(4) As Integer
        'testScores = [95, 78, 0, 0, 0]
        '      index:  0    1  2  3  4

        'Assign elements


        'Try it: assign the 2nd score to 78


        'Try it: assign the last score to a number entered
        'in an input box



        'Display all the scores in the Listbox (Long Way)
        ListBox1.Items.Add("Test Scores")



    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'Looping through an array
        Dim testScores(29) As Integer

        Dim r As New Random

        testScores(0) = r.Next(75, 101)
        testScores(1) = r.Next(75, 101)
        testScores(2) = r.Next(75, 101)
        testScores(3) = r.Next(75, 101)
        testScores(4) = r.Next(75, 101)
        testScores(5) = r.Next(75, 101)
        testScores(6) = r.Next(75, 101)
        testScores(7) = r.Next(75, 101)
        testScores(8) = r.Next(75, 101)
        testScores(9) = r.Next(75, 101)
        testScores(10) = r.Next(75, 101)
        testScores(11) = r.Next(75, 101)
        testScores(12) = r.Next(75, 101)
        testScores(13) = r.Next(75, 101)
        testScores(14) = r.Next(75, 101)
        testScores(15) = r.Next(75, 101)
        testScores(16) = r.Next(75, 101)
        testScores(17) = r.Next(75, 101)
        testScores(18) = r.Next(75, 101)
        testScores(19) = r.Next(75, 101)
        testScores(20) = r.Next(75, 101)
        testScores(21) = r.Next(75, 101)
        testScores(22) = r.Next(75, 101)
        testScores(23) = r.Next(75, 101)
        testScores(24) = r.Next(75, 101)
        testScores(25) = r.Next(75, 101)
        testScores(26) = r.Next(75, 101)
        testScores(27) = r.Next(75, 101)
        testScores(28) = r.Next(75, 101)
        testScores(29) = r.Next(75, 101)

        'Display all scores with a loop
        ListBox1.Items.Add("All Scores")



        'Display As
        ListBox1.Items.Add("The As")



        'Try it: Display the Bs
        ListBox1.Items.Add("The Bs")



    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'Linear Search
        Dim numbers(99) As Integer

        'Fill the array with random numbers
        Dim r As New Random
        Dim i As Integer
        For i = 0 To 99
            numbers(i) = r.Next(0, 125)
        Next

        'Define what we are searching for


        'How can we know if toFind wasn't found?


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim y, x, temp As Integer

        Dim numbers(7) As Integer
        numbers(0) = 6
        numbers(1) = 5
        numbers(2) = 3
        numbers(3) = 1
        numbers(4) = 8
        numbers(5) = 7
        numbers(6) = 2
        numbers(7) = -4

        'Bubble Sort
        '************
        For y = 0 To numbers.Length - 2 'Repeat this process over and over
            For x = 0 To numbers.Length - 2 'Loop through the elements
                'Is element x bigger than element x+1?
                If numbers(x) > numbers(x + 1) Then
                    'Flip-flop element x and x+1
                    temp = numbers(x)
                    numbers(x) = numbers(x + 1)
                    numbers(x + 1) = temp
                End If
            Next
        Next


        ListBox1.Items.Add("After Bubble Sort:")
        For i = 0 To numbers.Length - 1
            ListBox1.Items.Add(numbers(i))
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Create a 2-d array
        Dim myArray(2, 3) As Integer '3 rows, 4 cols
        'myArray:  0 0 0 0
        '          0 0 0 0

        'Access the elements using a row # and col #


        'myArray:  5 0 0 0
        '          0 0 0 1

        'Try it: Set the top-right corner and bottom left
        'corner to 3 and 7 respectively



        'Set all the elements to 10 (The loop way)
        Dim row, col As Integer




        'myArray:  10 10 10 10
        '          10 10 10 10

    End Sub







    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PictureBox1.Image = My.Resources.Bubble_sort_example_300px
    End Sub


End Class
