﻿using RefactorHelper.Models.Comparer;
using RefactorHelper.Models.RequestHandler;
using RefactorHelper.Models.SwaggerProcessor;

namespace RefactorHelper.Models
{
    public class RequestWrapper
    {
        public required int Id { get; set; }

        public required RequestState State { get; set; }

        public bool Changed { get; set; }

        public bool Executed => TestResult != null;

        public required RequestDetails Request { get; set; }

        public RefactorTestResultPair? TestResult { get; set; }

        public CompareResultPair? CompareResultPair { get; set; }

        public void Clear()
        {
            TestResult = null;
            CompareResultPair = null;
            State = RequestState.Pending;
        }
    }
}
