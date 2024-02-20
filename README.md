# HTTP5101 Assignment 2



The Canadian Computing Competition (CCC) is a yearly event hosted by the University of Waterloo. The past contests are available through the link below.

[https://cemc.math.uwaterloo.ca/contests/past_contests.html#ccc](https://cemc.math.uwaterloo.ca/contests/past_contests.html#ccc)

## This assignment requires you to:
- Create a WebAPI Method which solves a J1 Problem
- Create a WebAPI Method which solves a J2 Problem
- Initiative: Create a WebAPI Method that attempts a J3 or higher problem.
  
The questions on the CCC assume that the program input works through a terminal. Below are two example questions which have been
modified to work with WebAPI HTTP request inputs rather than terminal inputs. You may solve the two examples below; or look through the past
contests for problems.


## J3 Problem

Link [https://cemc.math.uwaterloo.ca/contests/computing/past_ccc_contests/2011/stage1/juniorEn.pdf](https://cemc.math.uwaterloo.ca/contests/computing/past_ccc_contests/2011/stage1/juniorEn.pdf)

Problem Description

In a sumac sequence, t1, t2, .., tm, each term is an integer greater than or equal 0. Also, each term,
starting with the third, is the difference of the preceding two terms (that is, tn+2 = tn − tn+1 for
n ≥ 1). The sequence terminates at tm if tm−1 < tm.

For example, if we have 120 and 71, then the sumac sequence generated is as follows:

120, 71, 49, 22, 27.

This is a sumac sequence of length 5.

Input Specification
The input will be two positive numbers t1 and t2, with 0 < t2 < t1 < 10000.

Output Specification

The output will be the length of the sumac sequence given by the starting numbers t1 and t2.
**Sample Input**
120
71
**Output for Sample Input**
5
