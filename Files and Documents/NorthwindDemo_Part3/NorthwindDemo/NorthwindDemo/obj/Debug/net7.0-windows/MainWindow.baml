   M S B A M L   `   `   `  ����G  CINFT3000Demo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:INFT3000DemoINFT3000Demo  5   	       INFT3000Demo.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:INFT3000Demo     5   	   -   5          � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5
         home �� 	UriSource  customer  products�� 5   
   %�   &	        &	 /     &	 b     �� 5      $ /images/home.png?�6'   6F   �� 5      $ /images/customer.png?�6+   6N   �� 5      $ /images/package.png?�6+   6M   5      .��5      ]� .+�5   
   o� $	��Top=�6   .@�5      m� $
��File��6   .@�5      m� $��_Exit��6   6,   5      m� 5      $��Pages��6   .@�5      m� -   5         m�Name$
 Home��5      $��_Home��6)    m� Icon 5      �� 5      #��[  6    6A   5      m� 5      -   5        $ ViewCustomer��5      $��_View Tracks��61    5      �� 5       #��[ 6    6E   5"      m� 5#      -   5        $ ViewProducts��5#      $��_View Albums��61    5$      �� 5%      #��[ 6    6E   5'      m� 5(      -   5        $ ViewArtists��5(      $��_View Artists��60   5)      5*      5+      c� 5,   
   $
��Left=�6   .@�5-      ��  �� Orientation$ Vertical=�6   $��50��60   .+�5.      �� -   5         ��Name$ 
HomeButton��5.      .��5/      �� #��[  6   6=   50      �� 51      -   5        $ CustomerButton��51      .��52      �� #��[ 6   6A   53      �� 54      -   5        $ ProductsButton��54      .��55      �� #��[ 6   6A   56      �� 57      -	   5        $ ArtistsButton��57      $��50��6J   $
��Arts��6V   58      59      5:       � 5;   
   -
   5          �Name$ 	mainFrame��5;      $
��Auto��6#   $
��Auto��61     � NavigationUIVisibility$ Hidden=�6>   $��Bottom=�5<      5=      5>      5E      