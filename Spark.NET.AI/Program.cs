var api = new OpenAI_API.OpenAIAPI("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");
var result = await api.Completions.GetCompletion("One Two Three One Two");
Console.WriteLine(result);
// should print something starting with "Three"