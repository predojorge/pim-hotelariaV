import 'package:bloc/bloc.dart';
import 'package:boilerplate_flutter/shared/exceptions/incorrect_credentials.dart';
import '../../data/user_repository.dart';

import '../../shared/services/user_service.dart';
import 'login_state.dart';

class LoginCubit extends Cubit<LoginState> {
  final UserService userService;
  final UserRepository userRepository;

  LoginCubit({
    required this.userService,
    required this.userRepository,
  }) : super(LoginState());

  void login({
    required String email,
    required String pass,
  }) async {
    try {
      emit(LoginState(isLoading: true));
      final token = await userRepository.login(email: email, pass: pass);
      await userService.saveToken(token);
      emit(LoginState(isLoading: false, isLogged: true));
    } on IncorrectCredentials {
      emit(LoginState(isLoading: false, message: 'Credenciais incorretas!'));
    } catch (e) {
      emit(LoginState(isLoading: false, message: 'Erro!'));
    }
  }
}
