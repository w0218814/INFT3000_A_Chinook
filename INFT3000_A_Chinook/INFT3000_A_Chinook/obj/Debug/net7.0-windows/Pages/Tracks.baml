   M S B A M L   `   `   `  ����M  IINFT3000_A_Chinook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:INFT3000_A_Chinook.PagesINFT3000_A_Chinook.Pages  5      M+clr-namespace:INFT3000_A_Chinook.ConvertersINFT3000_A_Chinook.Converters  5      %    INFT3000_A_Chinook.Pages.Tracks   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:INFT3000_A_Chinook.Pages     5      B
converters+clr-namespace:INFT3000_A_Chinook.Converters     5        N� Title$  Tracks��5
       � 	Resources 5         tracksViewSourceB   <INFT3000_A_Chinook.Converters.MillisecondsToMinutesConverter " MillisecondsToMinutesConverter=   7INFT3000_A_Chinook.Converters.BytesToMegabytesConverter  BytesToMegabytesConverter  BackgroundColor �� Color  AccentColor  	TextColor  SecondaryTextColor  DetailBackgroundColor �� 
TargetType �� Property �� Value  DetailBorderStyle��%`  &	        &	      &	 &     &	 9     &	 Z     &	 {     &	 �     &	 �     '�� �     7  '�� "    7  7  7  '�� �    7  7  &	 -    7  �� 5   
   6     5   
   64     5   
   6/   �� 5   
   $ #121212��62   �� 5   
   $ #1DB954��6.   �� 5   
   $ #FFFFFF��6,   �� 5   
   $ #B3B3B3��65   �� 5   
   $ #1DB954��68   �� 5   
   " ��6   .�5      ��  � ��8   6+   5      �� 5   
   " ��6   .�5      ��  � ��8   6+   �� 5       � ��8  6+   �� 5       � ��8  6,   �� 5       � ��$ 2q�60   5      �� 5    
   " ��6   .�5!      ��  � ��8   6+   �� 5"       � ��8  6+   5#      �� 5$   
   " ��6   .�5&      ��  � ��8   6+   �� 5'       �@��CornerRadius$ 5��6-   �� 5(       �@��Padding$ 5q�6(   5)      5*      .��5,      � $��10q�6   #��[ 6    � RowDefinitions 5-   
   �� 5.      $
��Auto �6   �� 50      $
��Auto �6   �� 52      $��* �6   .+�57   
   �� $��0��6   $��TRACKS��6!   $��48(�6/   $
��Left=�58      $��Center=�6/   #��[ 59      �� 5<   
   -   5         ��Name$ TrackSearchTextBox��5<      $��1��6.   $��Search by track name...��5=      $��5q�5A      $��3q�6   �� 5D   
   $
��Auto=�5E      $��Disabled=�5F      $��2��5G      $��Stretch=�5H      $��0,0,10,0q�5I      ��5D      ��  �� Source# [  ��5J      �� 5K      .R�5L      �� $��5q�6!   .+�5M      �� 	 �� Orientation$	 Vertical=�6%   $��5q�6<   .+�5N      �� $
��Bold"�6>   ��6(   �� *Name+6>   �� 5O      $��Italic$�6]   ��6(   �� *
Composer+
 �� TargetNullValue$
 Unknown��6]   5P      �� 5R      $
��Left=�6%   $��5,0,5,5q�6@   .+�5S      �� #��[ 6%   ._�5T   "   �� $	 
Horizontal=�6-   .+�5U   &   �� $	��5,0q�5V   0   #��[ 6=   ��5U   0   �� *Milliseconds+ �� 	Converter# [ 5V   =   �� 5W   &   $	��5,0q�5X   0   #��[ 6=   ��5W   0   �� *Bytes+# [ 5X   =   �� 5Y   &   $	��5,0q�5Z   0   #��[ 6=   ��5Y   0   �� *	UnitPrice+ �� StringFormat$ ${0:F2}��5Z   =   5[   #   5\      5]      5^      5_      5a      5b      5c      