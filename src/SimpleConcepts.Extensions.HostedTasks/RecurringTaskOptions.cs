﻿using System;

namespace SimpleConcepts.Extensions.HostedTasks
{
    public class RecurringTaskOptions
    {
        public TimeSpan WaitBeforeStart { get; set; }
        public TimeSpan WaitAfterCompletion { get; set; } = TimeSpan.FromSeconds(1);
        public TimeSpan WaitAfterException { get; set; } = TimeSpan.FromSeconds(1);
    }
}
