import java.awt.Color;
import java.awt.Graphics;
import java.io.BufferedInputStream;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.io.Serializable;
import java.util.ArrayList;
import java.util.List;

public class Aquarium implements Serializable{

	ClassArray<IAnimal> aquarium;

	// 4
	List<ClassArray<IAnimal>> aquariumStages;
	int currentLevel;
	//

	int countCell = 10;
	int cellW = 310;
	int cellH = 80;

	// 4
	public int getCurrentLevel() {
		return currentLevel;
	}
	//
	// 4
	public Aquarium(int countStages) {
		aquariumStages = new ArrayList<ClassArray<IAnimal>>(countStages);
		for (int i = 0; i < countStages; i++) {
			aquarium = new ClassArray<IAnimal>(countCell, null);
			aquariumStages.add(aquarium);
		}
	}

	public boolean Save(String s) throws IOException {
		FileOutputStream fos = new FileOutputStream(s);
		ObjectOutputStream oos = new ObjectOutputStream(fos);
		oos.writeObject(aquariumStages);
		
		return true;
		
	}
	
	public boolean Load(String o) throws ClassNotFoundException, IOException{
		FileInputStream fis = new FileInputStream(o);
		  ObjectInputStream oin = new ObjectInputStream(fis);
		  aquariumStages = (ArrayList<ClassArray<IAnimal>>)oin.readObject();
		  return true;
	}
	
	public void LevelUp() {
		if (currentLevel + 1 < aquariumStages.size()) {
			currentLevel++;
		}
	}

	public void LevelDown() {
		if (currentLevel > 0) {
			currentLevel--;
		}
	}
	//

	public int PutSharkInAquarium(IAnimal shark) {
		// 4
		return aquarium.Plus(aquariumStages.get(currentLevel), shark);
		//
	}

	public IAnimal GetSharkinAquarium(int ticket) {
		// 4
		return aquarium.Minus(aquariumStages.get(currentLevel), ticket);
		//
	}

	public void Draw(Graphics g, int w, int h) {
		DrawCells(g);
		for (int i = 0; i < countCell; i++) {
			IAnimal shark = aquariumStages.get(currentLevel).getObject(i);
			if (shark != null) {
				shark.setPos(5 + i / 5 * cellW + 100, i % 5 * cellH + 40);
				shark.drawAnimal(g);
			}
		}
	}

	private void DrawCells(Graphics g) {
		g.setColor(Color.BLACK);
		// 4
		g.drawString(("L" + currentLevel), (countCell / 5) * cellW - 70, 420);
		//

		for (int i = 0; i < countCell / 5; i++) {
			for (int j = 0; j < 5; ++j) {
				g.drawLine(i * cellW, j * cellH, i * cellW + 310, j * cellH);
				g.drawLine(i * cellW, j * cellH, i * cellW, j * cellH + cellH);
				// 4
				if (j < 5) {
					String str = "" + (i * 5 + j);
					g.drawString(str, i * cellW + 30, j * cellH + 20);
				}
				//
			}
		}
	}
}
