#define MyFunction _declspec(dllexport)

extern "C" {
	MyFunction int AddNumbers(int a, int b) {
		return a + b;
	}

	MyFunction int SubtractNumbers(int a, int b) {
		return a - b;
	}
}