using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMainScript : MonoBehaviour{
	public int row = 5;
	public int line = 6;
	public GameObject player_cube_one;
	public GameObject player_cube_two;
    // Start is called before the first frame update
    void Start(){
			int[,] board_state = new int[row + 2, line + 2];
			for(int i = 0; i < row + 2; i ++){
				for(int j = 0; j < line ; j++){
					board_state[i, j] = 0;
				}
			}
			for(int i = 1; i <= row; i++){
				board_state[i, 1] = 1;
				board_state[i, line] = 2;
			}
			printBoard(board_state);
    }

    // Update is called once per frame
    void Update(){
        
    }

		// bool move(int from_x, int from_y, int to_x, int to_y, int color){
		// 	switch(board_state[to_x, to_y]){
		// 				case 0:
		// 					if(board_state[to_x, to_y] )
		// 					break;
		// 				case 1:
            	
		// 					break;
		// 				case 2:
            	
		// 					break;
		// 				case 3:
            	
		// 					break;
		// 				case 4:
            	
		// 					break;
		// 				case 5:
            	
		// 					break;
		// 				case 6:
            	
		// 					break;
		// 	return true;
		// }

		void printBoard(int[,] board_state){
			for(int i = 0; i < row + 2; i ++){
				for(int j = 0; j < line + 2 ; j++){
						Vector3 pos1 = new Vector3(i, 1, j);
						Vector3 pos2 = new Vector3(i, 2, j);
						Vector3 pos3 = new Vector3(i, 3, j);
						switch(board_state[i, j]){
						case 0:
							break;
						case 1:
            	Instantiate(player_cube_one, pos1, Quaternion.identity);
							break;
						case 2:
            	Instantiate(player_cube_two, pos1, Quaternion.identity);
							break;
						case 3:
            	Instantiate(player_cube_one, pos1, Quaternion.identity);
            	Instantiate(player_cube_one, pos2, Quaternion.identity);
							break;
						case 4:
            	Instantiate(player_cube_two, pos1, Quaternion.identity);
            	Instantiate(player_cube_two, pos2, Quaternion.identity);
							break;
						case 5:
            	Instantiate(player_cube_two, pos1, Quaternion.identity);
            	Instantiate(player_cube_one, pos2, Quaternion.identity);
							break;
						case 6:
            	Instantiate(player_cube_one, pos1, Quaternion.identity);
            	Instantiate(player_cube_two, pos2, Quaternion.identity);
							break;
						case 7:
            	Instantiate(player_cube_one, pos1, Quaternion.identity);
            	Instantiate(player_cube_one, pos2, Quaternion.identity);
            	Instantiate(player_cube_one, pos3, Quaternion.identity);
							break;
						case 8:
            	Instantiate(player_cube_two, pos1, Quaternion.identity);
            	Instantiate(player_cube_two, pos2, Quaternion.identity);
            	Instantiate(player_cube_two, pos3, Quaternion.identity);
							break;
						case 9:
            	Instantiate(player_cube_two, pos1, Quaternion.identity);
            	Instantiate(player_cube_one, pos2, Quaternion.identity);
            	Instantiate(player_cube_one, pos3, Quaternion.identity);
							break;
						case 10:
            	Instantiate(player_cube_one, pos1, Quaternion.identity);
            	Instantiate(player_cube_two, pos2, Quaternion.identity);
            	Instantiate(player_cube_two, pos3, Quaternion.identity);
							break;
						case 11:
            	Instantiate(player_cube_one, pos1, Quaternion.identity);
            	Instantiate(player_cube_two, pos2, Quaternion.identity);
            	Instantiate(player_cube_one, pos3, Quaternion.identity);
							break;
						case 12:
            	Instantiate(player_cube_two, pos1, Quaternion.identity);
            	Instantiate(player_cube_one, pos2, Quaternion.identity);
            	Instantiate(player_cube_two, pos3, Quaternion.identity);
							break;
						case 13:
            	Instantiate(player_cube_two, pos1, Quaternion.identity);
            	Instantiate(player_cube_two, pos2, Quaternion.identity);
            	Instantiate(player_cube_one, pos3, Quaternion.identity);
							break;
						case 14:
            	Instantiate(player_cube_one, pos1, Quaternion.identity);
            	Instantiate(player_cube_one, pos2, Quaternion.identity);
            	Instantiate(player_cube_two, pos3, Quaternion.identity);
							break;
						case 15:
							break;
					}
				}
			}
		}
}
