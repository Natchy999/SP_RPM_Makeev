class Score:
    # конструктор базового класса с единственным атрибутом
    def __init__(self, pts):
        self.pts = pts
    
class RankingResult(Score):
    # конструктор производного класса с дополненными атрибутами
    def __init__(self, pts, grade, rankingplace):
        super().__init__(pts) 
        self.grade = grade
        self.rankingplace = rankingplace

    # вывод атрибутов в консоль
    def show_career_result(self):
        print(f"Счёт: {self.pts}\nРейтинг: {self.grade}\nМесто в топе: {self.rankingplace}")

careerResult = RankingResult(16000, "S+", 1)
careerResult.show_career_result()