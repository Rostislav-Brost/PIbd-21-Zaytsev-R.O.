import java.io.Serializable;
import java.util.Dictionary;
import java.util.Hashtable;
import java.util.Iterator;

class ClassArray<T> implements Serializable, Iterator<T>, Iterable<T>,
		Comparable<ClassArray<T>> {
	private T IAnimal;
	// private IAnimal[] cells;
	// 4
	private Dictionary<Integer, T> cells;
	private int maxCount;
	//
	private T defaultValue;

	public ClassArray(int size, T defVal) {
		defaultValue = defVal;
		// 4
		cells = new Hashtable<Integer, T>();
		maxCount = size;
		//
	}

	public static int Plus(ClassArray<IAnimal> c, IAnimal shark)
			throws AquOverflowException{

		boolean isTigherShark = shark instanceof TigerShark;

		// 4
		if (c.cells.size() == c.maxCount) {
			throw new AquOverflowException();
		}
		//
		int index = c.cells.size();
		for (int i = 0; i < c.cells.size(); i++) {
			if (c.ChekFreeCell(i)) {
				index = i;
			}
			if (shark.getClass()==c.cells.get(i).getClass()) {
				if (isTigherShark) {
					if (((TigerShark) shark).equals(c.cells.get(i))) {
						try {
							throw new AquariumAlreadyHaveException();
						} catch (AquariumAlreadyHaveException e) {
							// TODO Auto-generated catch block
							e.printStackTrace();
						}
					}
				} else if (((Shark) shark).equals(c.cells.get(i))) {
					try {
						throw new AquariumAlreadyHaveException();
					} catch (AquariumAlreadyHaveException e) {
						// TODO Auto-generated catch block
						e.printStackTrace();
					}
				}
			}
		}
		if (index != c.cells.size()) {
			c.cells.put(index, shark);
			return index;
		}

		// 4
		c.cells.put(c.cells.size(), shark);
		return c.cells.size() - 1;
		//
	}

	public static IAnimal Minus(ClassArray<IAnimal> c, int index)
			throws AquIndexOutOfRangeException {
		// 4
		if (c.cells.get(index) != null) {
			IAnimal shark = c.cells.get(index);
			c.cells.remove(index);
			return shark;
		}
		//
		throw new AquIndexOutOfRangeException();
	}

	private boolean ChekFreeCell(int index) {
		// 4
		return cells.get(index) == null;
		//
	}

	public T getObject(int ind) {
		if (ind > -1 && ind < cells.size()) {
			return cells.get(ind);
		}
		return defaultValue;
	}

	@Override
	public int compareTo(ClassArray<T> other) {
		// TODO Auto-generated method stub
		if (cells.size() > other.cells.size()) {
			return -1;
		} else if (cells.size() < other.cells.size()) {
			return 1;
		} else {
			for (int i = 0; i < this.cells.size(); i++) {
				if ((cells.get(cells.keys().nextElement())) instanceof Shark
						&& (other.cells.get(other.cells.keys().nextElement())) instanceof TigerShark) {
					return 1;
					
				}
				if ((this.cells.get(cells.keys().nextElement()))instanceof TigerShark
						&& (other.cells.get(other.cells.keys().nextElement()))instanceof Shark) {
					return -1;
				}
				if ((this.cells.get(cells.keys().nextElement()))instanceof Shark
						&& (other.cells.get(other.cells.keys().nextElement()))instanceof Shark) {
					
					return ((Shark) this.cells.get(cells.keys().nextElement()))
							.compareTo((Shark) other.cells.get(other.cells.keys().nextElement()));
				}
				if ((this.cells.get(cells.keys().nextElement()))instanceof TigerShark
						&& (other.cells.get(other.cells.keys().nextElement()))instanceof TigerShark) {
					return ((TigerShark) this.cells.get(cells.keys().nextElement()))
							.compareTo((TigerShark) other.cells.get(other.cells.keys().nextElement()));
				}
			}
		}
		return 0;
	}

	private int currentIndex;

	@Override
	public Iterator<T> iterator() {
		// TODO Auto-generated method stub
		return this;
	}

	@Override
	public boolean hasNext() {
		// TODO Auto-generated method stub
		if (currentIndex + 1 >= cells.size()) {
			Reset();
			return false;
		}
		currentIndex++;
		return true;
	}

	private void Reset() {
		// TODO Auto-generated method stub
		currentIndex = -1;
	}

	@Override
	public T next() {
		// TODO Auto-generated method stub
		return (T) cells.get(currentIndex);
	}

}