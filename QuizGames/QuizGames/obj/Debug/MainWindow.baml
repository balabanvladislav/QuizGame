   M S B A M L   `   `   `  ����D  @QuizGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:QuizGames	QuizGames  5   	       QuizGames.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:QuizGames     5   	     � Title$  Simple Quiz Game��5   	   $	��600��6"   $	��800��6/   .��5	      �� -   5         ��Name$ myCanvas��5	      
�������.+�5
   
   �� -   5        $��	scoreText��5
      $��18(�6!   .��6/   Scorul: 0/66<   �� 5   
   -   5         ��Name$ lblTime��5      $��18(�6!   $��Center=�6/   $��Center=�6L    �� Left$	 688��6g   $��	Timpul: 0��6y   $��96��6�   �� 5   
   -   5        $��qImage��5      $��images/main.png��6   $��Uniform=�67   $	��286��6I   $	��572��6V   $	 104��6b   
 �� Top$ 50��6t   �� 5   
   -   5        $��txtQuestion��5       �� TextAlignment$ Center=�6'    �� Padding$ 3q�6>   $��20(�6J   $	��572��6X   $
��Wrap=�6d   $	 104��6x   $	 348��6�   ��Hi welcome to this quiz game and we will be showing lots of different questions and you will click on the answer buttons to answer them.5      �� 5   
   -   5        $
��ans1��5   L   
���� ��$��18(�6*   $	��200��6X   $��50��6d   $��Answer 1��6p   
 � Tag$ 0��6�   $	 104��6�   $	 418��6�   �� 5   
   -   5        $
��ans2��5   L   
���� ��$��18(�6*   $	��200��6X   $��50��6d   $��Answer 2��6p   $ 0��6�   $	 104��6�   $	 486��6�    J� RenderTransformOrigin$ 0.516,-0.245&�6�   �� 5   
   -   5        $
��ans3��5   L   
���� ��$��18(�6*   $	��200��6X   $��50��6d   $��Answer 3��6p   $ 0��6�   $	 476��6�   $	 418��6�   �� 5   
   -	   5        $
��ans4��5   L   
���� ��$��18(�6*   $	��200��6X   $��50��6d   $��Answer 4��6p   $ 0��6�   $	 476��6�   $	 486��6�   5      5      