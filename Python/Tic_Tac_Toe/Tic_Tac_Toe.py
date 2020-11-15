################################################################################
##### This code is a basic tic tac toe game that was used to help learn the used
##### of functions in the python language.
##### Author: Dan Gray                                              Date 3/07/19

keep_playing = True
decided = False
picked = []
player1 = ' '
player2 = ' '
play = ["#", " ", " ",  " ", " ", " ", " ",  " ", " ", " "]
gameover = False
x_wins=0
o_wins=0


def player1_select(select):
    selected = False
    while not selected:
        if select.upper() == 'X':
            select = 'X'
            selected = True
            return select
        elif select.upper() == 'O':
            select = 'O'
            selected = True
            return select
        else:
            select = input("Invalid: Please select if you want to be X or O:\t")
            selected = False


def player2_select(select):
    if select == 'X':
        return 'O'
    else:
        return 'X'


def display_board(board):
    print('\t\t\t   |   |   ')
    print('\t'*3,board[7],'|',board[8],'|',board[9],' ')
    print('\t\t\t___|___|___')
    print('\t\t\t   |   |   ')
    print('\t'*3,board[4],'|',board[5],'|',board[6],' ')
    print('\t\t\t___|___|___')
    print('\t\t\t   |   |   ')
    print('\t'*3,board[1],'|',board[2],'|',board[3],' ')
    print('\t\t\t   |   |   ')


def player_input(move):
    move_done=False
    while not move_done:
        if (move in "123456789") and (move != ''):
            move = int(move)
            if (move in range(1, 10)) and (move not in picked):
                move=int(move)
                picked.append(move)
                return move
                move_done = True
            elif (move in range(1, 10)) and (move not in picked):
                picked.append(move)
                move_done =True
            else:
                move = input("Invalid Move or move is already taken: Where would you like to put you mark? (1-9) \t")
                move_done = False
        else:
            move = input("Invalid Move or move is already taken: Where would you like to put you mark? (1-9) \t")
            move_done = False


def win_conditions(play):
    if (play[1]=='X' and play[2]=='X' and play[3]=='X') or (play[1]=='O' and play[2]=='O' and play[3]=='O'):
        return play.pop(1)
    elif (play[1]=='X' and play[4]=='X' and play[7]=='X') or (play[1]=='O' and play[4]=='O' and play[7]=='O'):
        return play.pop(1)
    elif (play[1]=='X' and play[5]=='X' and play[9]=='X') or (play[1]=='O' and play[5]=='O' and play[9]=='O'):
        return play.pop(1)
    elif (play[2]=='X' and play[5]=='X' and play[8]=='X') or (play[2]=='O' and play[5]=='O' and play[8]=='O'):
        return play.pop(2)
    elif (play[3]=='X' and play[6]=='X' and play[9]=='X') or (play[3]=='O' and play[6]=='O' and play[9]=='O'):
        return play.pop(3)
    elif (play[4]=='X' and play[5]=='X' and play[6]=='X') or (play[4]=='O' and play[5]=='O' and play[6]=='O'):
        return play.pop(4)
    elif (play[7]=='X' and play[8]=='X' and play[9]=='X') or (play[7]=='O' and play[8]=='O' and play[9]=='O'):
        return play.pop(7)
    elif (play[3]=='X' and play[5]=='X' and play[7]=='X') or (play[3]=='O' and play[5]=='O' and play[7]=='O'):
        return play.pop(3)
    else:
        pass

def score_keeper(result):
    global x_wins
    global o_wins
    if result == 'X':
        x_wins+=1
    elif result == "O":
        o_wins+=1
    else:
        pass




########################################################################################################################
####################################### Main Code Starts here ##########################################################
########################################################################################################################
while keep_playing:
    player1 = input("Please select if you want to be X or O:\t")
    player1=player1_select(player1)
    player2=player2_select(player1)
    print('\n'*50)
    print("Player 1 is: "+ player1+"\t\t Player 2 is: "+ player2)
    display_board(play)
    print('X goes first.')
    while len(picked)<9 and (not gameover):
        if len(picked)%2==0:
            if player1 == 'X':
                p1 = (input("Player 1, Where would you like to put you mark? (1-9) \t"))
                p1 = player_input(p1)
                play[p1] = 'X'
            else:
                p2 = (input("Player 2, Where would you like to put you mark? (1-9) \t"))
                p2 = player_input(p2)
                play[p2]= 'X'
        else:
            if player1 == '0':
                p1 = (input("Player 1, Where would you like to put you mark? (1-9) \t"))
                p1 = player_input(p1)
                play[p1] = '0'
            else:
                p2 = (input("Player 2, Where would you like to put you mark? (1-9) \t"))
                p2 = player_input(p2)
                play[p2] = 'O'

        print('\n'* 50)
        display_board(play)
        win = win_conditions(play)
        print ("Score \t X: ",x_wins,"\t O: ",o_wins)
        if win=='X' or win == "O":
            if win == "X" and player1 == "X":
                print('\t'*3 + 'Player 1 WINS!!!')
                score_keeper(win)
                gameover = True
            elif win == "O" and player1 == "O":
                print('\t'*3 + 'Player 1 WINS!!!')
                score_keeper(win)
                gameover = True
            elif win == "X" and player2 == "X":
                print('\t'*3 + 'Player 2 WINS!!!')
                win
                score_keeper(win)
                gameover = True
    while keep_playing and gameover:
        while not decided:
            playagain = input('Do you want to play again: ')
            if playagain.upper() == 'YES':
                keep_playing = True
                decided = True
                picked =[]
                play = ["#", " ", " ", " ", " ", " ", " ", " ", " ", " "]
                gameover = False
                print('\n'*50)
                display_board(play)
            elif playagain.upper() == 'NO':
                keep_playing = False
                decided = True
                print()
                print("Score \t X: ", x_wins, "\t O: ", o_wins)
            else:
                print('Invalid response')
                decided = False
