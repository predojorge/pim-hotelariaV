import 'dart:io';

import 'package:boilerplate_flutter/shared/exceptions/incorrect_credentials.dart';
import 'package:dio/dio.dart';

import '../shared/exceptions/exceptions.dart';

class UserRepository {
  final Dio dio;

  UserRepository({
    required this.dio,
  });

  Future<String> login({
    required String email,
    required String pass,
  }) async {
    try {
      if (email == "admin@admin.com" && pass == "admin") {
        return 'token';
      }
      throw IncorrectCredentials();
    } on DioError catch (e) {
      if (e.response?.statusCode == 401) {
        throw UnauthorizedException();
      }
      rethrow;
    } on SocketException {
      throw NoInternetConnectionException();
    } catch (e) {
      rethrow;
    }
  }
}
