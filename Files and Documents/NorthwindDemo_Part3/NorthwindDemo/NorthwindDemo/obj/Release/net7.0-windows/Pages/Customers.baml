   M S B A M L   `   `   `  ���� H  DNorthwindDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:NorthwindDemo.PagesNorthwindDemo.Pages  #    NorthwindDemo.Pages.Customers   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     3local!clr-namespace:NorthwindDemo.Pages       N� Title$  	Customers�� � 	Resources    customerViewSource��%   &	        �� .����  �� Orientation$ Vertical=�.+��� $��CUSTOMERS PAGE��$��48(�&   System.Windows.Controls.DataGrid  $	��300��   AutoGenerateColumns$ False��!   EnableColumnVirtualization$
 True������  �� Source# [     Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   SortDirection 
Descending   Header$ Company Name��	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 SizeToHeader 
   
IsReadOnly$

 True��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *CompanyName+  $ Contact Name��$	 SizeToHeader $

 True�� �� *ContactName+  $ Address��$	 SizeToHeader $

 True�� �� *	Address+  $
 City��$	 SizeToHeader $

 True�� �� *City+  $ Country��$	 SizeToHeader $

 True�� �� *	Country+  $ PhoneAndFax��$	 SizeToHeader $

 True�� �� *PhoneAndFax+�� -    ��Name$ 
SaveButton��$
��Save��