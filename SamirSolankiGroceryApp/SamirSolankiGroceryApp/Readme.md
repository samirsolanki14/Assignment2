Name:- Samir Ashok Solanki
Student Number:- 0785689
Assignment 2


{\rtf1\ansi\ansicpg1252\cocoartf2638
\cocoatextscaling0\cocoaplatform0{\fonttbl\f0\fnil\fcharset0 HelveticaNeue;}
{\colortbl;\red255\green255\blue255;\red0\green0\blue0;\red255\green255\blue255;\red0\green0\blue252;
\red18\green18\blue18;\red11\green85\blue110;\red18\green18\blue18;\red11\green85\blue110;\red9\green60\blue148;
\red144\green1\blue18;\red70\green137\blue204;\red202\green202\blue202;\red140\green211\blue254;\red0\green0\blue252;
\red109\green109\blue109;\red194\green126\blue101;\red183\green111\blue179;}
{\*\expandedcolortbl;;\cssrgb\c0\c0\c0;\cssrgb\c100000\c100000\c100000;\cssrgb\c392\c392\c99216;
\cssrgb\c9020\c9020\c9020;\cssrgb\c0\c40784\c50588;\cssrgb\c9020\c9020\c9020;\cssrgb\c0\c40784\c50588;\cssrgb\c1569\c31765\c64706;
\cssrgb\c63922\c8235\c8235;\cssrgb\c33725\c61176\c83922;\cssrgb\c83137\c83137\c83137;\cssrgb\c61176\c86275\c99608;\cssrgb\c392\c392\c99216;
\cssrgb\c50196\c50196\c50196;\cssrgb\c80784\c56863\c47059;\cssrgb\c77255\c52549\c75294;}
\paperw11900\paperh16840\margl1440\margr1440\vieww11520\viewh8400\viewkind0
\pard\tx566\tx1133\tx1700\tx2267\tx2834\tx3401\tx3968\tx4535\tx5102\tx5669\tx6236\tx6803\pardirnatural\partightenfactor0

\f0\fs36 \cf2 \cb3 1) \expnd0\expndtw0\kerning0
\outl0\strokewidth0 \strokec4 dotnet\strokec5  \strokec4 new\strokec5  blazorserver\strokec6  -o\strokec5  SamirSolankiGroceryApp\
\
\
\pard\pardeftab720\partightenfactor0
\cf2 \strokec4 2)cd\strokec5  \outl0\strokewidth0 SamirSolankiGroceryApp\
\
\
\outl0\strokewidth0 \strokec4 3)dotnet\strokec5  \strokec4 new\strokec5  razorcomponent\strokec6  -n\strokec5  FoodList\strokec6  -o\strokec5  Pages\
\pard\pardeftab720\sa240\partightenfactor0
\cf2 \strokec5 \
4)\
\strokec4 @page\strokec6  \'93/FoodList\strokec5 \
\pard\pardeftab720\partightenfactor0
\cf2 \strokec5 \
\strokec4 <PageTitle> \outl0\strokewidth0 FoodList \outl0\strokewidth0 \strokec4 </PageTitle>\strokec5 \
\
\strokec4 <h1> \outl0\strokewidth0 FoodList \outl0\strokewidth0 \strokec4 </h1>\strokec5 \
\
\strokec4 @code \{\strokec5 \
\
\strokec4 \}\
\
\
5) IN \strokec5 Shared/NavMenu.razor used this code given below:-\
\
\
\pard\pardeftab720\partightenfactor0
\cf2 \strokec4 <div \strokec9 class\strokec4 =\strokec10 "nav-item px-3"\strokec4 >\strokec5 \
    \strokec4 <NavLink \strokec9 class\strokec4 =\strokec10 "nav-link"\strokec4  \strokec9 href\strokec4 =\strokec10 "\outl0\strokewidth0 FoodList\outl0\strokewidth0 \strokec10 "\strokec4 >\strokec5 \
        \strokec4 <span \strokec9 class\strokec4 =\strokec10 "oi oi-list-rich"\strokec4  \strokec9 aria-hidden\strokec4 =\strokec10 "true"\strokec4 ></span>\strokec5  \outl0\strokewidth0 FoodList\outl0\strokewidth0 \strokec5 \
    \strokec4 </NavLink>\strokec5 \
\strokec4 </div>\
\
6) Add In Fooditems.cs file  Add Parametrs\
public\strokec5  \strokec4 class\strokec5  \strokec6 FoodItem\strokec5 \
\{\
  \strokec11 public\strokec12  \strokec11 int\strokec12  \strokec13 quantity\strokec12 \{ \strokec11 get\strokec12 ; \strokec11 set\strokec12 ;\}\
    \strokec11 public\strokec12  \strokec11 int\strokec12  \strokec13 price\strokec12 \{ \strokec11 get\strokec12 ; \strokec11 set\strokec12 ;\}\
    \strokec11 public\strokec12  \strokec11 int\strokec12  \strokec13 foodproductnumber\strokec12 \{ \strokec11 get\strokec12 ; \strokec11 set\strokec12 ;\}\
    \strokec11 public\strokec12  \strokec11 string\strokec12 ? \strokec13 foodname\strokec12  \{ \strokec11 get\strokec12 ; \strokec11 set\strokec12 ;\}\
    \strokec11 public\strokec12  \strokec11 string\strokec12 ? \strokec13 fooddescription\strokec12  \{ \strokec11 get\strokec12 ; \strokec11 set\strokec12 ;\}\
\
    \strokec11 public\strokec12  \strokec11 int\strokec12  \strokec13 foodexpirydays\strokec12 \{ \strokec11 get\strokec12 ; \strokec11 set\strokec12 ;\}\
\pard\pardeftab720\partightenfactor0
\cf2 \strokec5 \
\}\
\
7 In FoodList.razor File add this code:-\
\
\pard\pardeftab720\partightenfactor0
\cf2 \strokec4 @page\strokec6  \'93/FoodList\'94\strokec5 \
\
\strokec4 <PageTitle> \outl0\strokewidth0 FoodList \outl0\strokewidth0 \strokec4 </PageTitle>\strokec5 \
\
\strokec4 <h1>\strokec5 Add \outl0\strokewidth0 FoodList\outl0\strokewidth0 \strokec4 </h1>\
\pard\pardeftab720\partightenfactor0
\cf2 \outl0\strokewidth0 <h3>Find Isle</h3>\outl0\strokewidth0 \strokec5 \
\pard\pardeftab720\partightenfactor0
\cf2 \
\pard\pardeftab720\partightenfactor0
\cf2 \strokec4 <ul>\strokec5 \
    \strokec4 @foreach\strokec5  (\strokec4 var\strokec5  foodlist \strokec4 in\strokec5  foods)\
    \strokec4 \{\strokec5 \
        \strokec4 <li>@\strokec5 foodlist.foodname\strokec4 </li>\strokec5 \
    \strokec4 \}\strokec5 \
\strokec4 </ul>\strokec5 \
\
\pard\pardeftab720\partightenfactor0
\cf2 \strokec15 <\strokec11 input\strokec12  \strokec13 placeholder\strokec12 =\strokec16 "Add Some FoodName"\strokec12  \strokec17 @bind\strokec12 =\strokec16 "newFoodName"\strokec12  \strokec15 />\strokec12 \
\pard\pardeftab720\partightenfactor0
\cf2 \strokec5 \
\
\pard\pardeftab720\partightenfactor0
\cf2 \strokec4 @code \{\strokec5 \
\pard\pardeftab720\partightenfactor0
\cf2 \strokec12   \strokec11 public\strokec12  \strokec13 bool\strokec12  \strokec13 IsDone\strokec12 \{\strokec13 get\strokec12 ;\strokec13 set\strokec12 ;\}\
\pard\pardeftab720\partightenfactor0
\cf2 \strokec4 \}\strokec5 \
}