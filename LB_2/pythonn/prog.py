class Score:
    # конструктор базового класса с единственным атрибутом
    def __init__(self, pts):
        self.pts = pts
    
class RankingResult(Score):
    # конструктор производного класса с дополненными атрибутами
    def __init__(self, pts, rankingplace):
        super().__init__(pts) 
        self.grade = self.calculate_rating()
        self.rankingplace = rankingplace

    # вывод атрибутов в консоль
    def show_career_result(self):
        print(f"Счёт: {self.pts}\nРейтинг: {self.grade}\nМесто в топе: {self.rankingplace}")
        
    def change_info(self, pts, rankingplace):
        super().__init__(pts)
        self.grade = self.calculate_rating()
        self.rankingplace = rankingplace

    def calculate_rating(self):
        if self.pts >= 15000:
            return "S"
        elif self.pts >= 13500:
            return "A"
        elif self.pts >= 12500:
            return "B"
        elif self.pts >= 11000:
            return "C"
        elif self.pts >= 10000:
            return "F"
        else:
            return "D"

careerResult = RankingResult(12425, 3)
careerResult.show_career_result()
careerResult.change_info(15977, 1)
careerResult.show_career_result()
