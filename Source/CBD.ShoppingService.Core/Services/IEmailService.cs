﻿namespace CBD.ShoppingService.Core.Services; 

public interface IEmailService {
	Task SendEmailAsync(string to, string subject, string message);
}