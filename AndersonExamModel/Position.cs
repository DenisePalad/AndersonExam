﻿using System.Collections.Generic;

namespace AndersonExamModel
{
    public class Position : Base.Base
    {
        public static readonly Position positionId;

        public int PositionId { get; set; }
        public string Description { get; set; }
        public string PositionName { get; set; }

        public virtual ICollection<ExamPosition> ExamPositions { get; set; }
        public virtual ICollection<Examinee> Examinees { get; set; }
    }
}
