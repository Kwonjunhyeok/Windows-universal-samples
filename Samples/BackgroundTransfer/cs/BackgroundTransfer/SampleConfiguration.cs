//*********************************************************
//
// Copyright (c) Microsoft. All rights reserved.
// This code is licensed under the MIT License (MIT).
// THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY
// IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR
// PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.
//
//*********************************************************

using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;

namespace SDKTemplate
{
    public partial class MainPage : Page
    {
        public const string FEATURE_NAME = "BackgroundTransfer";

        List<Scenario> scenarios = new List<Scenario>
        {
            new Scenario() { Title="File Download", ClassType=typeof(Scenario1_Download)},
            new Scenario() { Title="File Upload", ClassType=typeof(Scenario2_Upload)},
            new Scenario() { Title="Completion Notifications", ClassType=typeof(Scenario3_Notifications)},
            new Scenario() { Title="Completion Groups", ClassType=typeof(Scenario4_CompletionGroups)},
            new Scenario() { Title="Random Access Downloads", ClassType=typeof(Scenario5_RandomAccess)},
            new Scenario() { Title="Recoverable Errors", ClassType=typeof(Scenario6_RecoverableErrors)}
        };
    }

    public class Scenario
    {
        public string Title { get; set; }
        public Type ClassType { get; set; }
    }
}
