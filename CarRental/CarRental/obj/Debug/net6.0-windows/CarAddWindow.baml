   M S B A M L   `   `   `  ����D  @CarRental, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:CarRental	CarRental  5   	       CarRental.CarAddWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:CarRental     5   	     � Title$  CarAddWindow��5   	   $	��450��6   $	��800��6+   .��5	      � .+�5
   
   �� $
��Left=�6   $��400,100,0,0q�6-    �� TextWrapping$
 Wrap=�6B   $��TextBox��6V   $	��Top=�6e   $	��101��6}   �� 5   
   $
��Make��6   $
��Left=�6   $��
332,96,0,0q�6:   $	��Top=�6N    J� RenderTransformOrigin$ -1.567,1.623&�6f   � 5   
   $��296,-30,-296,30q�6   .+�5      �� $
��Left=�6   $��104,130,0,0q�61   $
 Wrap=�6F   $��TextBox��6Z   $	��Top=�6i   $	��101��6�   �� 5      $��Model��6   $
��Left=�6$   $��
36,166,0,0q�6?   $	��Top=�6S   $ -1.567,1.623&�6k   �� 5      -   5        $��model��5      $
��Left=�6#   $��104,170,0,0q�6>   $
 Wrap=�6S   $��TextBox��6g   $	��Top=�6v   $	��101��6�   � 5       � RowDefinitions 5      �� 5      $	��82* �6$   �� 5      $
��135* �6$   .+�5      �� -   5        $
��make��5      $
��Left=�6&   $��104,130,0,0q�6A   $
 Wrap=�6V   $��TextBox��6j   $	��Top=�6y   $	��101��6�   �� 5      $
��Year��6   $
��Left=�6'   $��	36,49,0,0q�6B   $	��Top=�6U   $ -1.567,1.623&�6m   $��1��6�   �� 5      -   5        $
��year��5      $
��Left=�6&   $��
104,53,0,0q�6A   $
 Wrap=�6U   $��TextBox��6i   $	��Top=�6x   $	��101��6�   $��1��6�   6�   �� 5      $��Color��6   $
��Left=�6(   $��	36,97,0,0q�6C   $	��Top=�6V   $ -1.567,1.623&�6n   $��1��6�   �� 5      -   5        $��color��5      $
��Left=�6'   $��104,101,0,0q�6B   $
 Wrap=�6W   $��TextBox��6k   $	��Top=�6z   $	��101��6�   $��1��6�   �� 5      $��Rental Rate��6   $
��Left=�6.   $��
20,147,0,0q�6I   $	��Top=�6]   $ -1.567,1.623&�6u   $��1��6�   �� 5      -   5        $��rental_rate��5      $
��Left=�6-   $��104,151,0,0q�6H   $
 Wrap=�6]   $��TextBox��6q   $	��Top=�6�   $	��101��6�   $��1��6�   �� 5      $��	Available��6   $
��Left=�6,   $��
30,202,0,0q�6G   $��1��6[   $	��Top=�6h   $ 0.829,-1.636&�6�   �� 5      -   5        $��	available��5      $�� ��6,   $
��Left=�67   $��
93,208,0,0q�6R   $��1��6f   $	��Top=�6s   �� 5      -   5        $��	addbutton��5      $	��Add��6*   $
��Left=�68   $��154,184,0,0q�6S   $��1��6h   $	��Top=�6u   $��53��6�   $��51��6�   5      5       �� 5!   
   $��	Add a CAR��6   $
��Left=�6$   $��
352,54,0,0q�6?   $	��Top=�6S   $��20(�6k   5"      5#      