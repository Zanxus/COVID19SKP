   M S B A M L   `   `   `  ����T  PCalculatorAndGuessingGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:CalculatorAndGuessingGameCalculatorAndGuessingGame  5   	   2    ,CalculatorAndGuessingGame.GuessingGameWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:CalculatorAndGuessingGame     5   	     � Title$  GuessingGameWindow��5   	   $��270.492��6$   $��923.525��65   .��5	      � $��0,0,0,26q�6   .+�5
   
   �� -   5        $��Back To Main Menu��5
      $
��Left=�6-   $��657,384,0,0q�6H   $	��Top=�6]   $	��111��6u   6�   �� 5   
   $��Guessing Game��6   $
��Left=�6(   $��	23,23,0,0q�6C   $	��Top=�6V   $	��175��6n   $��42��6z   $��24(�6�   �� 5   
   $��Instructions:��6   $
��Left=�6(   $��
628,31,0,0q�6C   $	��Top=�6W   $��18(�6o   �� 5   
   $
��Left=�6   $��
639,70,0,0q�6/   $
��Wrap=�6C   $����Guess the number between 0-10 within 3 tries, the game will say if you need to go higher or lower. each right guess gives 1 point. Guesses carry over. if you guess correctly the game automaticly gives you a new number to guess if you use all your guesses the game will reset. If you want to add your name to the highscore please enter a name in the name box.��5   
   $	��Top=�5   
   $	��267��6"   �� 5   
   -   5         ��Name$ 
GuessInput��5      $
��Left=�6&   $��23��6A   $��	23,95,0,0q�6M    �� TextWrapping$
 Wrap=�6`   $	��Top=�6t   $	��120��6�   �� 5   
   -   5         ��Name$ 
OutputText��5      $
��Left=�6$   $��
23,144,0,0q�6?   $	��Top=�6S   $��40��6k   $	��390��6w   $��18(�6�   �� 5   
   -   5        $��Guess��5      $
��Left=�6!   $��
148,95,0,0q�6<   $	��Top=�6P   $��70��6h   $��23��6s   6   �� 5   
   $��Guesses:��6   $
��Left=�6#   $��	23,62,0,0q�6>   $	��Top=�6Q   $��33��6i   $��70��6u   �� 5   
   -   5        $ GuessAmountLabel��5      $
��Left=�6F   $��	93,62,0,0q�6a   $	��Top=�6t   $��50��6�   $��28��6�   ��6*   �� *	Guesses+6�   �� 5   
   -   5         ��Name$ HiscoreListVeiw��5      $
��Left=�6,   $	��180��6G   $��
451,23,0,0q�6T   $	��Top=�6h   $	��155��6�    �� View 5      �� 5      -   5        ListGrid��.P�5      �� $
��Name��6%    �� Width$ 50��63    �� DisplayMemberBinding 6>   �� *Name+�� 5      $��Score��6%   $ 90��64    6?   �� *Score+5      5      �� 5   
   $��Hiscore��6   $
��Left=�6"   $��	451,0,0,0q�6=   $	��Top=�6P   $	��155��6h   �� 5   
   -   5        $ HiscoreName��5      $
��Left=�6'   $��23��6B   $��
326,48,0,0q�6N   $
 Wrap=�6b   $�� ��6v   $	��Top=�6~   $	��120��6�   �� 5   
   $
��Name��6   $
��Left=�6   $��
326,23,0,0q�6:   $	��Top=�6N   5!      5"      