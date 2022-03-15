﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class TestMap1
    {
        /// <summary>
        /// [x,y,i]
        /// x = x location
        /// y = y location
        /// i = item number
        /// </summary>
        private string testMap =
            "[1,1,1][2,1,1][3,1,1][4,1,1][5,1,1][6,1,1][7,1,1][8,1,1][9,1,1][10,1,1][11,1,1][12,1,1][13,1,1][14,1,1][15,1,1][16,1,1][17,1,1][18,1,1][19,1,1][20,1,1][21,1,1][22,1,1][23,1,1][24,1,1][25,1,1][26,1,1][27,1,1][28,1,1][29,1,1][30,1,1][31,1,1][32,1,1][33,1,1][34,1,1][35,1,1][36,1,1][37,1,1][38,1,1][39,1,1][40,1,1][1,2,1][2,2,2][3,2,2][4,2,2][5,2,2][6,2,2][7,2,2][8,2,2][9,2,2][10,2,2][11,2,2][12,2,2][13,2,2][14,2,2][15,2,2][16,2,2][17,2,2][18,2,2][19,2,2][20,2,2][21,2,2][22,2,2][23,2,2][24,2,2][25,2,2][26,2,2][27,2,2][28,2,2][29,2,2][30,2,2][31,2,2][32,2,2][33,2,2][34,2,2][35,2,2][36,2,2][37,2,2][38,2,2][39,2,2][40,2,1][1,3,1][2,3,2][3,3,2][4,3,2][5,3,2][6,3,2][7,3,2][8,3,2][9,3,2][10,3,2][11,3,2][12,3,2][13,3,2][14,3,2][15,3,2][16,3,2][17,3,2][18,3,2][19,3,2][20,3,2][21,3,2][22,3,2][23,3,2][24,3,2][25,3,2][26,3,2][27,3,2][28,3,2][29,3,2][30,3,2][31,3,2][32,3,2][33,3,2][34,3,2][35,3,2][36,3,2][37,3,2][38,3,2][39,3,2][40,3,1][1,4,1][2,4,2][3,4,2][4,4,2][5,4,2][6,4,2][7,4,2][8,4,2][9,4,2][10,4,2][11,4,2][12,4,2][13,4,2][14,4,2][15,4,2][16,4,2][17,4,2][18,4,2][19,4,2][20,4,2][21,4,2][22,4,2][23,4,2][24,4,2][25,4,2][26,4,2][27,4,2][28,4,2][29,4,2][30,4,2][31,4,2][32,4,2][33,4,2][34,4,2][35,4,2][36,4,2][37,4,2][38,4,2][39,4,2][40,4,1][1,5,1][2,5,2][3,5,2][4,5,2][5,5,2][6,5,2][7,5,2][8,5,2][9,5,2][10,5,2][11,5,2][12,5,2][13,5,2][14,5,2][15,5,2][16,5,2][17,5,2][18,5,2][19,5,2][20,5,2][21,5,2][22,5,2][23,5,2][24,5,2][25,5,2][26,5,2][27,5,2][28,5,2][29,5,2][30,5,2][31,5,2][32,5,2][33,5,2][34,5,2][35,5,2][36,5,2][37,5,2][38,5,2][39,5,2][40,5,1][1,6,1][2,6,2][3,6,2][4,6,2][5,6,2][6,6,2][7,6,2][8,6,2][9,6,2][10,6,2][11,6,2][12,6,2][13,6,2][14,6,2][15,6,2][16,6,2][17,6,2][18,6,2][19,6,2][20,6,2][21,6,2][22,6,2][23,6,2][24,6,2][25,6,2][26,6,2][27,6,2][28,6,2][29,6,2][30,6,2][31,6,2][32,6,2][33,6,2][34,6,2][35,6,2][36,6,2][37,6,2][38,6,2][39,6,2][40,6,1][1,7,1][2,7,2][3,7,2][4,7,2][5,7,2][6,7,2][7,7,2][8,7,2][9,7,2][10,7,2][11,7,2][12,7,2][13,7,2][14,7,2][15,7,2][16,7,2][17,7,2][18,7,2][19,7,2][20,7,2][21,7,2][22,7,2][23,7,2][24,7,2][25,7,2][26,7,2][27,7,2][28,7,2][29,7,2][30,7,2][31,7,2][32,7,2][33,7,2][34,7,2][35,7,2][36,7,2][37,7,2][38,7,2][39,7,2][40,7,1][1,8,1][2,8,2][3,8,2][4,8,2][5,8,2][6,8,2][7,8,2][8,8,2][9,8,2][10,8,2][11,8,2][12,8,2][13,8,2][14,8,2][15,8,2][16,8,2][17,8,2][18,8,2][19,8,2][20,8,2][21,8,2][22,8,2][23,8,2][24,8,2][25,8,2][26,8,2][27,8,2][28,8,2][29,8,2][30,8,2][31,8,2][32,8,2][33,8,2][34,8,2][35,8,2][36,8,2][37,8,2][38,8,2][39,8,2][40,8,1][1,9,1][2,9,2][3,9,2][4,9,2][5,9,2][6,9,2][7,9,2][8,9,2][9,9,2][10,9,2][11,9,2][12,9,2][13,9,2][14,9,2][15,9,2][16,9,2][17,9,2][18,9,2][19,9,2][20,9,2][21,9,2][22,9,2][23,9,2][24,9,2][25,9,2][26,9,2][27,9,2][28,9,2][29,9,2][30,9,2][31,9,2][32,9,2][33,9,2][34,9,2][35,9,2][36,9,2][37,9,2][38,9,2][39,9,2][40,9,1][1,10,1][2,10,2][3,10,2][4,10,2][5,10,2][6,10,2][7,10,2][8,10,2][9,10,2][10,10,2][11,10,2][12,10,2][13,10,2][14,10,2][15,10,2][16,10,2][17,10,2][18,10,2][19,10,2][20,10,2][21,10,2][22,10,2][23,10,2][24,10,2][25,10,2][26,10,2][27,10,2][28,10,2][29,10,2][30,10,2][31,10,2][32,10,2][33,10,2][34,10,2][35,10,2][36,10,2][37,10,2][38,10,2][39,10,2][40,10,1][1,11,1][2,11,2][3,11,2][4,11,2][5,11,2][6,11,2][7,11,2][8,11,2][9,11,2][10,11,2][11,11,2][12,11,2][13,11,2][14,11,2][15,11,2][16,11,2][17,11,2][18,11,2][19,11,2][20,11,2][21,11,2][22,11,2][23,11,2][24,11,2][25,11,2][26,11,2][27,11,2][28,11,2][29,11,2][30,11,2][31,11,2][32,11,2][33,11,2][34,11,2][35,11,2][36,11,2][37,11,2][38,11,2][39,11,2][40,11,1][1,12,1][2,12,2][3,12,2][4,12,2][5,12,2][6,12,2][7,12,2][8,12,2][9,12,2][10,12,2][11,12,2][12,12,2][13,12,2][14,12,2][15,12,2][16,12,2][17,12,2][18,12,2][19,12,2][20,12,2][21,12,2][22,12,2][23,12,2][24,12,2][25,12,2][26,12,2][27,12,2][28,12,2][29,12,2][30,12,2][31,12,2][32,12,2][33,12,2][34,12,2][35,12,2][36,12,2][37,12,2][38,12,2][39,12,2][40,12,1][1,13,1][2,13,2][3,13,2][4,13,2][5,13,2][6,13,2][7,13,2][8,13,2][9,13,2][10,13,2][11,13,2][12,13,2][13,13,2][14,13,2][15,13,2][16,13,2][17,13,2][18,13,2][19,13,2][20,13,2][21,13,2][22,13,2][23,13,2][24,13,2][25,13,2][26,13,2][27,13,2][28,13,2][29,13,2][30,13,2][31,13,2][32,13,2][33,13,2][34,13,2][35,13,2][36,13,2][37,13,2][38,13,2][39,13,2][40,13,1][1,14,1][2,14,2][3,14,2][4,14,2][5,14,2][6,14,2][7,14,2][8,14,2][9,14,2][10,14,2][11,14,2][12,14,2][13,14,2][14,14,2][15,14,2][16,14,2][17,14,2][18,14,2][19,14,2][20,14,2][21,14,2][22,14,2][23,14,2][24,14,2][25,14,2][26,14,2][27,14,2][28,14,2][29,14,2][30,14,2][31,14,2][32,14,2][33,14,2][34,14,2][35,14,2][36,14,2][37,14,2][38,14,2][39,14,2][40,14,1][1,15,1][2,15,2][3,15,2][4,15,2][5,15,2][6,15,2][7,15,2][8,15,2][9,15,2][10,15,2][11,15,2][12,15,2][13,15,2][14,15,2][15,15,2][16,15,2][17,15,2][18,15,2][19,15,2][20,15,2][21,15,2][22,15,2][23,15,2][24,15,2][25,15,2][26,15,2][27,15,2][28,15,2][29,15,2][30,15,2][31,15,2][32,15,2][33,15,2][34,15,2][35,15,2][36,15,2][37,15,2][38,15,2][39,15,2][40,15,1][1,16,1][2,16,2][3,16,2][4,16,2][5,16,2][6,16,2][7,16,2][8,16,2][9,16,2][10,16,2][11,16,2][12,16,2][13,16,2][14,16,2][15,16,2][16,16,2][17,16,2][18,16,2][19,16,2][20,16,2][21,16,2][22,16,2][23,16,2][24,16,2][25,16,2][26,16,2][27,16,2][28,16,2][29,16,2][30,16,2][31,16,2][32,16,2][33,16,2][34,16,2][35,16,2][36,16,2][37,16,2][38,16,2][39,16,2][40,16,1][1,17,1][2,17,2][3,17,2][4,17,2][5,17,2][6,17,2][7,17,2][8,17,2][9,17,2][10,17,2][11,17,2][12,17,2][13,17,2][14,17,2][15,17,2][16,17,2][17,17,2][18,17,2][19,17,2][20,17,2][21,17,2][22,17,2][23,17,2][24,17,2][25,17,2][26,17,2][27,17,2][28,17,2][29,17,2][30,17,2][31,17,2][32,17,2][33,17,2][34,17,2][35,17,2][36,17,2][37,17,2][38,17,2][39,17,2][40,17,1][1,18,1][2,18,2][3,18,2][4,18,2][5,18,2][6,18,2][7,18,2][8,18,2][9,18,2][10,18,2][11,18,2][12,18,2][13,18,2][14,18,2][15,18,2][16,18,2][17,18,2][18,18,2][19,18,2][20,18,2][21,18,2][22,18,2][23,18,2][24,18,2][25,18,2][26,18,2][27,18,2][28,18,2][29,18,2][30,18,2][31,18,2][32,18,2][33,18,2][34,18,2][35,18,2][36,18,2][37,18,2][38,18,2][39,18,2][40,18,1][1,19,1][2,19,2][3,19,2][4,19,2][5,19,2][6,19,2][7,19,2][8,19,2][9,19,2][10,19,2][11,19,2][12,19,2][13,19,2][14,19,2][15,19,2][16,19,2][17,19,2][18,19,2][19,19,2][20,19,2][21,19,2][22,19,2][23,19,2][24,19,2][25,19,2][26,19,2][27,19,2][28,19,2][29,19,2][30,19,2][31,19,2][32,19,2][33,19,2][34,19,2][35,19,2][36,19,2][37,19,2][38,19,2][39,19,2][40,19,1][1,20,1][2,20,2][3,20,2][4,20,2][5,20,2][6,20,2][7,20,2][8,20,2][9,20,2][10,20,2][11,20,2][12,20,2][13,20,2][14,20,2][15,20,2][16,20,2][17,20,2][18,20,2][19,20,2][20,20,2][21,20,2][22,20,2][23,20,2][24,20,2][25,20,2][26,20,2][27,20,2][28,20,2][29,20,2][30,20,2][31,20,2][32,20,2][33,20,2][34,20,2][35,20,2][36,20,2][37,20,2][38,20,2][39,20,2][40,20,1][1,21,1][2,21,2][3,21,2][4,21,2][5,21,2][6,21,2][7,21,2][8,21,2][9,21,2][10,21,2][11,21,2][12,21,2][13,21,2][14,21,2][15,21,2][16,21,2][17,21,2][18,21,2][19,21,2][20,21,2][21,21,2][22,21,2][23,21,2][24,21,2][25,21,2][26,21,2][27,21,2][28,21,2][29,21,2][30,21,2][31,21,2][32,21,2][33,21,2][34,21,2][35,21,2][36,21,2][37,21,2][38,21,2][39,21,2][40,21,1][1,22,1][2,22,2][3,22,2][4,22,2][5,22,2][6,22,2][7,22,2][8,22,2][9,22,2][10,22,2][11,22,2][12,22,2][13,22,2][14,22,2][15,22,2][16,22,2][17,22,2][18,22,2][19,22,2][20,22,2][21,22,2][22,22,2][23,22,2][24,22,2][25,22,2][26,22,2][27,22,2][28,22,2][29,22,2][30,22,2][31,22,2][32,22,2][33,22,2][34,22,2][35,22,2][36,22,2][37,22,2][38,22,2][39,22,2][40,22,1][1,23,1][2,23,2][3,23,2][4,23,2][5,23,2][6,23,2][7,23,2][8,23,2][9,23,2][10,23,2][11,23,2][12,23,2][13,23,2][14,23,2][15,23,2][16,23,2][17,23,2][18,23,2][19,23,2][20,23,2][21,23,2][22,23,2][23,23,2][24,23,2][25,23,2][26,23,2][27,23,2][28,23,2][29,23,2][30,23,2][31,23,2][32,23,2][33,23,2][34,23,2][35,23,2][36,23,2][37,23,2][38,23,2][39,23,2][40,23,1][1,24,1][2,24,2][3,24,2][4,24,2][5,24,2][6,24,2][7,24,2][8,24,2][9,24,2][10,24,2][11,24,2][12,24,2][13,24,2][14,24,2][15,24,2][16,24,2][17,24,2][18,24,2][19,24,2][20,24,2][21,24,2][22,24,2][23,24,2][24,24,2][25,24,2][26,24,2][27,24,2][28,24,2][29,24,2][30,24,2][31,24,2][32,24,2][33,24,2][34,24,2][35,24,2][36,24,2][37,24,2][38,24,2][39,24,2][40,24,1][1,25,1][2,25,2][3,25,2][4,25,2][5,25,2][6,25,2][7,25,2][8,25,2][9,25,2][10,25,2][11,25,2][12,25,2][13,25,2][14,25,2][15,25,2][16,25,2][17,25,2][18,25,2][19,25,2][20,25,2][21,25,2][22,25,2][23,25,2][24,25,2][25,25,2][26,25,2][27,25,2][28,25,2][29,25,2][30,25,2][31,25,2][32,25,2][33,25,2][34,25,2][35,25,2][36,25,2][37,25,2][38,25,2][39,25,2][40,25,1][1,26,1][2,26,2][3,26,2][4,26,2][5,26,2][6,26,2][7,26,2][8,26,2][9,26,2][10,26,2][11,26,2][12,26,2][13,26,2][14,26,2][15,26,2][16,26,2][17,26,2][18,26,2][19,26,2][20,26,2][21,26,2][22,26,2][23,26,2][24,26,2][25,26,2][26,26,2][27,26,2][28,26,2][29,26,2][30,26,2][31,26,2][32,26,2][33,26,2][34,26,2][35,26,2][36,26,2][37,26,2][38,26,2][39,26,2][40,26,1][1,27,1][2,27,2][3,27,2][4,27,2][5,27,2][6,27,2][7,27,2][8,27,2][9,27,2][10,27,2][11,27,2][12,27,2][13,27,2][14,27,2][15,27,2][16,27,2][17,27,2][18,27,2][19,27,2][20,27,2][21,27,2][22,27,2][23,27,2][24,27,2][25,27,2][26,27,2][27,27,2][28,27,2][29,27,2][30,27,2][31,27,2][32,27,2][33,27,2][34,27,2][35,27,2][36,27,2][37,27,2][38,27,2][39,27,2][40,27,1][1,28,1][2,28,2][3,28,2][4,28,2][5,28,2][6,28,2][7,28,2][8,28,2][9,28,2][10,28,2][11,28,2][12,28,2][13,28,2][14,28,2][15,28,2][16,28,2][17,28,2][18,28,2][19,28,2][20,28,2][21,28,2][22,28,2][23,28,2][24,28,2][25,28,2][26,28,2][27,28,2][28,28,2][29,28,2][30,28,2][31,28,2][32,28,2][33,28,2][34,28,2][35,28,2][36,28,2][37,28,2][38,28,2][39,28,2][40,28,1][1,29,1][2,29,2][3,29,2][4,29,2][5,29,2][6,29,2][7,29,2][8,29,2][9,29,2][10,29,2][11,29,2][12,29,2][13,29,2][14,29,2][15,29,2][16,29,2][17,29,2][18,29,2][19,29,2][20,29,2][21,29,2][22,29,2][23,29,2][24,29,2][25,29,2][26,29,2][27,29,2][28,29,2][29,29,2][30,29,2][31,29,2][32,29,2][33,29,2][34,29,2][35,29,2][36,29,2][37,29,2][38,29,2][39,29,2][40,29,1][1,30,1][2,30,2][3,30,2][4,30,2][5,30,2][6,30,2][7,30,2][8,30,2][9,30,2][10,30,2][11,30,2][12,30,2][13,30,2][14,30,2][15,30,2][16,30,2][17,30,2][18,30,2][19,30,2][20,30,2][21,30,2][22,30,2][23,30,2][24,30,2][25,30,2][26,30,2][27,30,2][28,30,2][29,30,2][30,30,2][31,30,2][32,30,2][33,30,2][34,30,2][35,30,2][36,30,2][37,30,2][38,30,2][39,30,2][40,30,1][1,31,1][2,31,2][3,31,2][4,31,2][5,31,2][6,31,2][7,31,2][8,31,2][9,31,2][10,31,2][11,31,2][12,31,2][13,31,2][14,31,2][15,31,2][16,31,2][17,31,2][18,31,2][19,31,2][20,31,2][21,31,2][22,31,2][23,31,2][24,31,2][25,31,2][26,31,2][27,31,2][28,31,2][29,31,2][30,31,2][31,31,2][32,31,2][33,31,2][34,31,2][35,31,2][36,31,2][37,31,2][38,31,2][39,31,2][40,31,1][1,32,1][2,32,2][3,32,2][4,32,2][5,32,2][6,32,2][7,32,2][8,32,2][9,32,2][10,32,2][11,32,2][12,32,2][13,32,2][14,32,2][15,32,2][16,32,2][17,32,2][18,32,2][19,32,2][20,32,2][21,32,2][22,32,2][23,32,2][24,32,2][25,32,2][26,32,2][27,32,2][28,32,2][29,32,2][30,32,2][31,32,2][32,32,2][33,32,2][34,32,2][35,32,2][36,32,2][37,32,2][38,32,2][39,32,2][40,32,1][1,33,1][2,33,2][3,33,2][4,33,2][5,33,2][6,33,2][7,33,2][8,33,2][9,33,2][10,33,2][11,33,2][12,33,2][13,33,2][14,33,2][15,33,2][16,33,2][17,33,2][18,33,2][19,33,2][20,33,2][21,33,2][22,33,2][23,33,2][24,33,2][25,33,2][26,33,2][27,33,2][28,33,2][29,33,2][30,33,2][31,33,2][32,33,2][33,33,2][34,33,2][35,33,2][36,33,2][37,33,2][38,33,2][39,33,2][40,33,1][1,34,1][2,34,2][3,34,2][4,34,2][5,34,2][6,34,2][7,34,2][8,34,2][9,34,2][10,34,2][11,34,2][12,34,2][13,34,2][14,34,2][15,34,2][16,34,2][17,34,2][18,34,2][19,34,2][20,34,2][21,34,2][22,34,2][23,34,2][24,34,2][25,34,2][26,34,2][27,34,2][28,34,2][29,34,2][30,34,2][31,34,2][32,34,2][33,34,2][34,34,2][35,34,2][36,34,2][37,34,2][38,34,2][39,34,2][40,34,1][1,35,1][2,35,2][3,35,2][4,35,2][5,35,2][6,35,2][7,35,2][8,35,2][9,35,2][10,35,2][11,35,2][12,35,2][13,35,2][14,35,2][15,35,2][16,35,2][17,35,2][18,35,2][19,35,2][20,35,2][21,35,2][22,35,2][23,35,2][24,35,2][25,35,2][26,35,2][27,35,2][28,35,2][29,35,2][30,35,2][31,35,2][32,35,2][33,35,2][34,35,2][35,35,2][36,35,2][37,35,2][38,35,2][39,35,2][40,35,1][1,36,1][2,36,2][3,36,2][4,36,2][5,36,2][6,36,2][7,36,2][8,36,2][9,36,2][10,36,2][11,36,2][12,36,2][13,36,2][14,36,2][15,36,2][16,36,2][17,36,2][18,36,2][19,36,2][20,36,2][21,36,2][22,36,2][23,36,2][24,36,2][25,36,2][26,36,2][27,36,2][28,36,2][29,36,2][30,36,2][31,36,2][32,36,2][33,36,2][34,36,2][35,36,2][36,36,2][37,36,2][38,36,2][39,36,2][40,36,1][1,37,1][2,37,2][3,37,2][4,37,2][5,37,2][6,37,2][7,37,2][8,37,2][9,37,2][10,37,2][11,37,2][12,37,2][13,37,2][14,37,2][15,37,2][16,37,2][17,37,2][18,37,2][19,37,2][20,37,2][21,37,2][22,37,2][23,37,2][24,37,2][25,37,2][26,37,2][27,37,2][28,37,2][29,37,2][30,37,2][31,37,2][32,37,2][33,37,2][34,37,2][35,37,2][36,37,2][37,37,2][38,37,2][39,37,2][40,37,1][1,38,1][2,38,2][3,38,2][4,38,2][5,38,2][6,38,2][7,38,2][8,38,2][9,38,2][10,38,2][11,38,2][12,38,2][13,38,2][14,38,2][15,38,2][16,38,2][17,38,2][18,38,2][19,38,2][20,38,2][21,38,2][22,38,2][23,38,2][24,38,2][25,38,2][26,38,2][27,38,2][28,38,2][29,38,2][30,38,2][31,38,2][32,38,2][33,38,2][34,38,2][35,38,2][36,38,2][37,38,2][38,38,2][39,38,2][40,38,1][1,39,1][2,39,2][3,39,2][4,39,2][5,39,2][6,39,2][7,39,2][8,39,2][9,39,2][10,39,2][11,39,2][12,39,2][13,39,2][14,39,2][15,39,2][16,39,2][17,39,2][18,39,2][19,39,2][20,39,2][21,39,2][22,39,2][23,39,2][24,39,2][25,39,2][26,39,2][27,39,2][28,39,2][29,39,2][30,39,2][31,39,2][32,39,2][33,39,2][34,39,2][35,39,2][36,39,2][37,39,2][38,39,2][39,39,2][40,39,1][1,40,1][2,40,1][3,40,1][4,40,1][5,40,1][6,40,1][7,40,1][8,40,1][9,40,1][10,40,1][11,40,1][12,40,1][13,40,1][14,40,1][15,40,1][16,40,1][17,40,1][18,40,1][19,40,1][20,40,1][21,40,1][22,40,1][23,40,1][24,40,1][25,40,1][26,40,1][27,40,1][28,40,1][29,40,1][30,40,1][31,40,1][32,40,1][33,40,1][34,40,1][35,40,1][36,40,1][37,40,1][38,40,1][39,40,1][40,40,1]";

        private List<Tile> playerPlacedTiles;
        private List<Item> playerPlacedItems;

        public TestMap1() {
            playerPlacedItems = new List<Item>();
            playerPlacedTiles = new List<Tile>();
        }

        public string getTestMap() {
            return testMap;
        }

        public void addToPlayerPlacedItems(Item item) {
            playerPlacedItems.Add(item);
        }

        public List<Item> getPlayerPlacedItems() {
            return playerPlacedItems;
        }

        public void addToPlayerPlacedTiles(Tile tile)
        {
            playerPlacedTiles.Add(tile);
        }

        public List<Tile> getPlayerPlacedTiles()
        {
            return playerPlacedTiles;
        }
    }
}